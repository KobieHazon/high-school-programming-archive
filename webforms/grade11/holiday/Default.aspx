<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Panel ID="Panel1" runat="server" Height="686px" style="margin-top: 0px">
        <asp:Label ID="Label1" runat="server" Text="HAPPY ROSH HASHANA!" 
            BorderStyle="Outset" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" 
            Font-Underline="True" ForeColor="#6666FF" style="margin-left: 144px" 
            Width="479px"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter your name good fellow: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        .<br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Press Me 7 times." />
        <br />
        <asp:Label ID="Label4" runat="server" Text="יקו" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="(SURPRISE)"></asp:Label>
    </asp:Panel>
    </form>
</body>
</html>
