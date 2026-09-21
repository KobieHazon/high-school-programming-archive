<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 223px;
        }
        .style2
        {
            width: 223px;
            height: 179px;
        }
        .style3
        {
            height: 179px;
            width: 422px;
        }
        .style4
        {
            width: 187px;
        }
        .style5
        {
            height: 179px;
            width: 187px;
        }
        .style6
        {
            width: 422px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: x-large">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Exercise</div>
        <center>
    <table style="width: 93%; height: 238px;">
        <tr>
            <td class="style1">
                <asp:Label ID="LblTable" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style4">
                <asp:Label ID="Lbl1" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Lbl2" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style6">
                <asp:TextBox ID="Txt1" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="Txt2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:TextBox ID="LstTables" runat="server" Height="110px"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:Label ID="Lbl3" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Lbl4" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Lbl5" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="Txt3" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="Txt4" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="Txt5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="LblCount" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style4">
                <asp:Label ID="Lbl6" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style6">
                <asp:TextBox ID="Txt6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Button ID="BtnConnect1" runat="server" Text="Connect" />
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style6">
                <asp:Button ID="BtnBack" runat="server" Text="&lt;" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnGo" runat="server" Text="&gt;" />
                <br />
                <br />
                <asp:Button ID="BtnFirst" runat="server" Text="&lt;&lt;" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnLast" runat="server" Text="&gt;&gt;" />
            </td>
        </tr>
    </table>
    </center>
    </form>
</body>
</html>
