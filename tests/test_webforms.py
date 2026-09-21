"""Render classic ASP.NET pages and submit real calculator form requests."""
from html.parser import HTMLParser
from http.cookiejar import CookieJar
from pathlib import Path
import shutil
import re
import subprocess
import tempfile
import time
import unittest
import urllib.parse
import urllib.request

ROOT = Path(__file__).resolve().parents[1]
PAGES = {
    'calculator': ['Kobie_Calc.aspx'], 'image-gallery': ['ImagesRay.aspx'],
    'pizza-order': ['kobie_pizza.aspx'], 'holiday': ['Default.aspx', 'Rosh Hashana.aspx'],
    'shop': ['Store.aspx'], 'text-style': ['TextStyle.aspx'],
    'clock': ['TimeLive.aspx'], 'photo-page': ['Default.aspx'],
}


class FormParser(HTMLParser):
    def __init__(self):
        super().__init__()
        self.fields = {}
        self.select = None
        self.select_default = False

    def handle_starttag(self, tag, attrs):
        attrs = dict(attrs)
        if tag == 'input' and attrs.get('type') == 'hidden':
            self.fields[attrs['name']] = attrs.get('value', '')
        if tag == 'input' and attrs.get('type') in ('radio','checkbox') and 'checked' in attrs:
            self.fields[attrs['name']] = attrs.get('value','on')
        if tag == 'select':
            self.select = attrs.get('name')
            self.select_default = int(attrs.get('size','1')) == 1
        if tag == 'option' and self.select and ('selected' in attrs or (self.select_default and self.select not in self.fields)):
            self.fields[self.select] = attrs.get('value','')

    def handle_endtag(self, tag):
        if tag == 'select':
            self.select = None


class WebFormsTests(unittest.TestCase):
    def serve(self, name):
        temp = tempfile.TemporaryDirectory()
        self.addCleanup(temp.cleanup)
        site = Path(temp.name) / 'site'
        shutil.copytree(ROOT / 'webforms/grade11' / name, site)
        (site / 'bin').mkdir(exist_ok=True)
        subprocess.run(['mcs','-r:System.Web','-out:'+str(site/'bin/Server.exe'),str(ROOT/'webforms/Server.cs')],check=True,capture_output=True)
        log = open(Path(temp.name)/'server.log','w+')
        self.addCleanup(log.close)
        process = subprocess.Popen(['mono',str(site/'bin/Server.exe'),str(site),'8080'],stdout=log,stderr=log)
        def stop():
            process.terminate()
            process.wait(timeout=10)
        self.addCleanup(stop)
        url = 'http://127.0.0.1:8080/' + urllib.parse.quote(PAGES[name][0])
        for _ in range(100):
            if process.poll() is not None:
                log.seek(0)
                self.fail(log.read())
            try:
                with urllib.request.urlopen(url,timeout=3) as response:
                    response.read()
                return url
            except ConnectionError:
                time.sleep(.1)
            except urllib.error.URLError as error:
                if isinstance(error, urllib.error.HTTPError):
                    self.fail(error.read().decode())
                time.sleep(.1)
        self.fail('ASP.NET server did not start')

    def test_calculator_operations(self):
        url = self.serve('calculator')
        for op, expected in [('+','9'),('-','3'),('*','18'),('/','2')]:
            with self.subTest(operator=op):
                with urllib.request.urlopen(url) as response:
                    html = response.read().decode()
                parser = FormParser()
                parser.feed(html)
                fields = {**parser.fields, 'TextBox1':'6','TextBox2':'3','RadioButtonList1':op,'Button1':'חשב'}
                with urllib.request.urlopen(url,urllib.parse.urlencode(fields).encode()) as response:
                    output = response.read().decode()
                self.assertIn('id="Label2"', output)
                self.assertRegex(output, r'id="Label2"[^>]*>'+expected+r'</span>')

    def test_shop_order_and_session(self):
        url = self.serve('shop')
        client = urllib.request.build_opener(urllib.request.HTTPCookieProcessor(CookieJar()))
        with client.open(url) as response:
            parser = FormParser()
            parser.feed(response.read().decode())
        fields = {**parser.fields, 'btnOrder':'Order'}
        try:
            response = client.open(url, urllib.parse.urlencode(fields).encode())
        except urllib.error.HTTPError as error:
            page = error.read().decode()
            self.fail(str(re.findall(r'<h[12][^>]*>(.*?)</h[12]>', page)))
        with response:
            html = response.read().decode()
            self.assertTrue(response.url.endswith('/Recipt.aspx'))
        self.assertNotIn('no order', html)
        self.assertRegex(html, r'id="lblcomp"[^>]*>Pc</span>')

    def test_clock_time_and_script_resources(self):
        url = self.serve('clock')
        with urllib.request.urlopen(url) as response:
            html = response.read().decode()
        self.assertRegex(html, r'id="lblTime"[^>]*>[^<]*\d{1,2}:\d{2}:\d{2}')
        from html import unescape
        scripts = re.findall(r'<script[^>]+src="([^"]+)"', html)
        self.assertTrue(scripts)
        for script in scripts:
            with urllib.request.urlopen(urllib.parse.urljoin(url, unescape(script))) as response:
                self.assertTrue(response.read())
        parser = FormParser()
        parser.feed(html)
        fields = {**parser.fields, '__EVENTTARGET':'Timer1', '__EVENTARGUMENT':'', '__ASYNCPOST':'true', 'ScriptManager1':'UpdatePanel1|Timer1'}
        request = urllib.request.Request(url, urllib.parse.urlencode(fields).encode(), {'X-MicrosoftAjax':'Delta=true'})
        with urllib.request.urlopen(request) as response:
            delta = response.read().decode()
        self.assertIn('|updatePanel|UpdatePanel1|', delta)


def page_test(site):
    def check(self):
        self.serve(site)
        for page in PAGES[site]:
            with urllib.request.urlopen('http://127.0.0.1:8080/'+urllib.parse.quote(page),timeout=10) as response:
                html = response.read().decode()
            self.assertIn('<form',html)
            self.assertNotIn('Compilation Error',html)
            self.assertNotIn('Exception Details',html)
        with urllib.request.urlopen('http://127.0.0.1:8080/sample.svg') as response:
            self.assertEqual(response.headers.get_content_type(),'image/svg+xml')
    return check


for name in PAGES:
    setattr(WebFormsTests, 'test_render_'+name.replace('-','_'), page_test(name))

if __name__ == '__main__':
    unittest.main()
