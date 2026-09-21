<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TextStyle.aspx.cs" Inherits="TextStyle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 407px">
    
        Write Anything:<asp:TextBox ID="TextBox1" runat="server" Height="21px" 
            ontextchanged="TextBox1_TextChanged" Width="190px" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <br />
        choose front color (html-colors) :<asp:TextBox ID="TextBox2" runat="server" 
            ontextchanged="TextBox2_TextChanged" AutoPostBack="True"></asp:TextBox>
        <br />
        choose back color (html-colors) :<asp:TextBox 
            ID="TextBox3" runat="server" 
            ontextchanged="TextBox3_TextChanged" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" 
            oncheckedchanged="CheckBox1_CheckedChanged" Text="Bold?" 
            AutoPostBack="True" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" 
            oncheckedchanged="CheckBox2_CheckedChanged" Text="Italic?" 
            AutoPostBack="True" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox3" runat="server" 
            oncheckedchanged="CheckBox3_CheckedChanged" Text="UnderLine?" 
            AutoPostBack="True" />
        <br />
        <br />
        Choose Text Size:
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>XX-small</asp:ListItem>
            <asp:ListItem>X-small</asp:ListItem>
            <asp:ListItem>Small</asp:ListItem>
            <asp:ListItem>Medium</asp:ListItem>
            <asp:ListItem>Large</asp:ListItem>
            <asp:ListItem>X-large</asp:ListItem>
            <asp:ListItem>XX-large</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Choose Font:<asp:TextBox ID="TextBox4" runat="server" AutoPostBack="True" 
            ontextchanged="TextBox4_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="(Surprise)" Font-Size="Medium"></asp:Label>
    
    </div>
    </form>
</body>
</html>
