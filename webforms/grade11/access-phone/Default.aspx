<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style13
        {
            width: 208px;
            height: 50px;
        }
        .style1
        {
            width: 206px;
            height: 50px;
        }
        
        .style4
        {
            height: 50px;
        }
        .style14
        {
            width: 208px;
            height: 70px;
        }
        .style3
        {
            width: 206px;
            height: 70px;
        }
        .style15
        {
            width: 208px;
            height: 33px;
        }
        .style10
        {
            width: 206px;
            height: 33px;
        }
        .style11
        {
            height: 33px;
        }
        .style16
        {
            width: 208px;
            height: 319px;
        }
        .style5
        {
            width: 206px;
            height: 319px;
        }
        .style12
        {
            height: 319px;
        }
        </style>
</head>
<body>
    <p id="Client" align="center" 
        style="color:#800080; font-weight: bold; font-size: x-large;">
        Client Managment Website&nbsp;
    </p>
    <form id="form1" runat="server">
    <table align="center" style="height: 565px; width: 713px;">
        <tr>
            <td class="style13" style="color: #333399">
                &nbsp;<asp:Label ID="LblTable" runat="server" Font-Bold="True" ForeColor="#333399" 
                    Text="Label"></asp:Label>
            </td>
            <td class="style1">
                <asp:Label ID="lbl1" runat="server" Font-Bold="True" ForeColor="#333399" 
                    Text="Label"></asp:Label>
                <br />
                <asp:Label ID="lbl2" runat="server" Font-Bold="True" ForeColor="#333399" 
                    Text="Label"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="Txt1" runat="server" Font-Bold="True" ForeColor="#333399" 
                    ontextchanged="Txt1_TextChanged"></asp:TextBox>
                <br />
                <asp:TextBox ID="Txt2" runat="server" Font-Bold="True" ForeColor="#333399" 
                    ontextchanged="Txt2_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style14">
                <asp:ListBox ID="LstTables" runat="server" AutoPostBack="True" Font-Bold="True" 
                    ForeColor="#333399" Height="94px" 
                    onselectedindexchanged="LstTables_SelectedIndexChanged" Width="93px">
                </asp:ListBox>
            </td>
            <td class="style3">
                <asp:Label ID="lbl3" runat="server" Font-Bold="True" ForeColor="#333399" 
                    Text="Label"></asp:Label>
                <br />
                <asp:Label ID="lbl4" runat="server" Font-Bold="True" ForeColor="#333399" 
                    Text="Label"></asp:Label>
                <br />
                <asp:Label ID="lbl5" runat="server" Font-Bold="True" ForeColor="#333399" 
                    Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Txt3" runat="server" Font-Bold="True" ForeColor="#333399" 
                    ontextchanged="Txt3_TextChanged"></asp:TextBox>
                <br />
                <asp:TextBox ID="Txt4" runat="server" Font-Bold="True" ForeColor="#333399" 
                    ontextchanged="Txt4_TextChanged"></asp:TextBox>
                <br />
                <asp:TextBox ID="Txt5" runat="server" Font-Bold="True" ForeColor="#333399" 
                    ontextchanged="Txt5_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style15">
                <asp:Label ID="LblCount" runat="server" Font-Bold="True" ForeColor="#333399" 
                    Text="Label"></asp:Label>
            </td>
            <td class="style10">
                <asp:Label ID="lbl6" runat="server" Font-Bold="True" ForeColor="#333399" 
                    Text="Label"></asp:Label>
            </td>
            <td class="style11">
                <asp:TextBox ID="Txt6" runat="server" Font-Bold="True" ForeColor="#333399" 
                    ontextchanged="Txt6_TextChanged" Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style16">
                <asp:Button ID="BtnConnect" runat="server" onclick="BtnConnect_Click" 
                    Text="Connect" />
            </td>
            <td align="center" class="style5" dir="ltr" rowspan="2">
                <br />
            </td>
            <td align="char" class="style12" dir="ltr" rowspan="2">
                <asp:Button ID="BtnBack" runat="server" Height="52px" onclick="BtnBack_Click" 
                    Text="&lt;" Width="50px" />
                <asp:Button ID="BtnGo" runat="server" Height="52px" onclick="BtnGo_Click" 
                    Text="&gt;" Width="50px" />
                <br />
                <asp:Button ID="BtnFirst" runat="server" Height="52px" onclick="BtnFirst_Click" 
                    Text="&lt;&lt;" Width="50px" />
                <asp:Button ID="BtnLast" runat="server" Height="52px" onclick="BtnLast_Click" 
                    Text="&gt;&gt;" Width="50px" />
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
