<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Recipt.aspx.cs" Inherits="Recipt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 188px;
        }
    </style>
</head>
<body>
<center><h1 style="color:#336600">Receipt</h1>

    <form id="form1" runat="server">
    <table style="border:5px double black; height: 180px; width: 353px;" 
        frame="vsides">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Computer:" Font-Bold="True" 
                    ForeColor="#3333FF"></asp:Label></td>
            <td class="style1">
                <asp:Label ID="lblcomp" runat="server" Text="Label" Font-Bold="True" 
                    ForeColor="#660066"></asp:Label></td>
        </tr>

          <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Office Stuff:" Font-Bold="True" 
                    ForeColor="#3333FF"></asp:Label></td>
            <td class="style1">
                <asp:Label ID="lbloffice" runat="server" Text="Label" Font-Bold="True" 
                    ForeColor="#660066"></asp:Label></td>
        </tr>

          <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Extra Component:" Font-Bold="True" 
                    ForeColor="#3333FF"></asp:Label></td>
            <td class="style1">
                <asp:Label ID="lblextra" runat="server" Text="Label" Font-Bold="True" 
                    ForeColor="#660066"></asp:Label></td>
        </tr>

          <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Payment:" Font-Bold="True" 
                    ForeColor="#3333FF"></asp:Label></td>
            <td class="style1">
                <asp:Label ID="lblPay" runat="server" Text="Label" Font-Bold="True" 
                    ForeColor="#660066"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnchange" runat="server" Text="Change Order" 
                    onclick="btnchange_Click" /></td>
        </tr>
    
    </table>
  

    </form>
    </center>
</body>
</html>
