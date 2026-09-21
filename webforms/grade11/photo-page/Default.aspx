<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackImageUrl="sample.svg" 
            Height="754px">
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Ray and his dad</asp:ListItem>
                <asp:ListItem>Sexy Ray</asp:ListItem>
                <asp:ListItem>Beautiful Ray</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ListBox1_SelectedIndexChanged">
                <asp:ListItem>Ray and his dad</asp:ListItem>
                <asp:ListItem>Sexy Ray</asp:ListItem>
                <asp:ListItem>Beautiful Ray</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="sample.svg" 
                Height="408px" Width="420px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
