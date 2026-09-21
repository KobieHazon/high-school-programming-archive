// Local teaching server for classic ASP.NET Web Forms (Mono / System.Web).
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Hosting;

[Serializable]
public class PageResponse
{
    public int Status = 200;
    public string Body;
    public List<string[]> Headers = new List<string[]>();
}

public class PageHost : MarshalByRefObject
{
    public override object InitializeLifetimeService() { return null; }

    public PageResponse Render(string page, string query, string method, string body, string cookie, string ajax)
    {
        using (var output = new StringWriter())
        {
            var request = new FormRequest(page, query, method, body, cookie, ajax, output);
            HttpRuntime.ProcessRequest(request);
            request.Result.Body = output.ToString();
            return request.Result;
        }
    }
}

public class FormRequest : SimpleWorkerRequest
{
    readonly string method;
    readonly byte[] body;
    readonly string cookie;
    readonly string ajax;
    public PageResponse Result = new PageResponse();

    public FormRequest(string page, string query, string method, string body, string cookie, string ajax, TextWriter output)
        : base(page, query, output)
    {
        this.method = method;
        this.body = Encoding.UTF8.GetBytes(body);
        this.cookie = cookie;
        this.ajax = ajax;
    }

    public override string GetHttpVerbName() { return method; }
    public override string GetKnownRequestHeader(int index)
    {
        if (index == HeaderContentType) return "application/x-www-form-urlencoded";
        if (index == HeaderContentLength) return body.Length.ToString();
        if (index == HeaderHost) return "localhost";
        if (index == HeaderCookie) return cookie;
        return base.GetKnownRequestHeader(index);
    }
    public override byte[] GetPreloadedEntityBody() { return body; }
    public override bool IsEntireEntityBodyIsPreloaded() { return true; }
    public override int GetTotalEntityBodyLength() { return body.Length; }
    public override string GetUnknownRequestHeader(string name)
    {
        return String.Equals(name, "X-MicrosoftAjax", StringComparison.OrdinalIgnoreCase) ? ajax : base.GetUnknownRequestHeader(name);
    }
    public override string[][] GetUnknownRequestHeaders()
    {
        return ajax == null ? new string[0][] : new[]{new[]{"X-MicrosoftAjax", ajax}};
    }
    public override void SendStatus(int code, string description) { Result.Status = code; }
    public override void SendKnownResponseHeader(int index, string value) { Result.Headers.Add(new[]{GetKnownResponseHeaderName(index), value}); }
    public override void SendUnknownResponseHeader(string name, string value) { Result.Headers.Add(new[]{name, value}); }
}

public class Server
{
    public static void Main(string[] args)
    {
        if (args.Length != 2) throw new ArgumentException("Usage: mono Server.exe SITE PORT");
        string root = Path.GetFullPath(args[0]);
        var host = (PageHost)ApplicationHost.CreateApplicationHost(typeof(PageHost), "/", root);
        using (var listener = new HttpListener())
        {
            // Intended for the disposable Docker container only; publish to host loopback.
            listener.Prefixes.Add("http://*:" + int.Parse(args[1]) + "/");
            listener.Start();
            Console.WriteLine("Web Forms teaching server listening on " + args[1]);
            while (true)
            {
                var context = listener.GetContext();
                try
                {
                    string page = Uri.UnescapeDataString(context.Request.Url.AbsolutePath).TrimStart('/');
                    if (page.Length == 0) page = "Default.aspx";
                    if (page.Contains("..") || page.Contains("\\") || !(page.EndsWith(".aspx", StringComparison.OrdinalIgnoreCase) || page == "sample.svg" || page == "WebResource.axd" || page == "ScriptResource.axd"))
                    {
                        context.Response.StatusCode = 404;
                        continue;
                    }
                    string result;
                    if (page == "sample.svg")
                    {
                        context.Response.ContentType = "image/svg+xml";
                        result = File.ReadAllText(Path.Combine(root, page));
                    }
                    else
                    {
                        string body;
                        using (var input = new StreamReader(context.Request.InputStream)) body = input.ReadToEnd();
                        var rendered = host.Render(page, context.Request.Url.Query.TrimStart('?'), context.Request.HttpMethod, body, context.Request.Headers["Cookie"], context.Request.Headers["X-MicrosoftAjax"]);
                        result = rendered.Body;
                        context.Response.StatusCode = rendered.Status;
                        context.Response.ContentType = "text/html; charset=utf-8";
                        foreach (var header in rendered.Headers)
                        {
                            if (String.Equals(header[0], "Content-Length", StringComparison.OrdinalIgnoreCase) || String.Equals(header[0], "Transfer-Encoding", StringComparison.OrdinalIgnoreCase)) continue;
                            context.Response.AppendHeader(header[0], header[1]);
                        }
                    }
                    byte[] bytes = Encoding.UTF8.GetBytes(result);
                    context.Response.OutputStream.Write(bytes, 0, bytes.Length);
                }
                catch (Exception e)
                {
                    context.Response.StatusCode = 500;
                    Console.Error.WriteLine(e);
                }
                finally { context.Response.Close(); }
            }
        }
    }
}
