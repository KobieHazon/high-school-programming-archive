<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Store.aspx.cs" Inherits="Store" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 180px;
        }
    </style>
</head>
<body>
<center>
    <h1 style="color:#008000">Shop</h1>

    <form id="form1" runat="server">
    <table>
        <tr>
            <td class="style1"><b>Computers Required</b></td>
            <td><b>Extra Components</b></td>
            <td align="center" colspan="2"><b>Your Orders</b></td>
            <td><b>Choose Order Date</b></td>
        </tr>
        <tr>
            <td align="left" class="style1">
                <asp:Panel ID="Panel1" runat="server" BorderColor="#3333FF" 
                    BorderStyle="Groove">
                    <asp:RadioButton ID="rdbPc" runat="server" GroupName="computers" Text="Pc" 
                        AutoPostBack="True" oncheckedchanged="rdbPc_CheckedChanged" /><br />
                    <asp:RadioButton ID="rdbMac" runat="server" GroupName="computers" 
                        Text="Machintosh" AutoPostBack="True" 
                        oncheckedchanged="rdbMac_CheckedChanged" /><br />
                    <asp:RadioButton ID="rdbLapTop" runat="server" GroupName="computers" 
                        Text="Lap Top" AutoPostBack="True" 
                        oncheckedchanged="rdbLapTop_CheckedChanged" />
                </asp:Panel>
            </td>
            <td>
                <asp:ListBox ID="lstItems" runat="server" Font-Bold="True" Height="100px" 
                    Width="137px" AutoPostBack="True" 
                    onselectedindexchanged="lstItems_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td>
            <asp:Image ID="img1" runat="server" Height="95px" Width="105px" ImageAlign="Middle" 
                    ImageUrl="sample.svg" />       
            </td>
            <td>
                <asp:Image ID="img2" runat="server" Height="91px" Width="102px" 
                    ImageUrl="sample.svg" />
            </td>
            <td>
                <asp:Calendar ID="ca" runat="server" onselectionchanged="ca_SelectionChanged"></asp:Calendar>
            </td>
        </tr>

        <tr>
            <td align="left" >
                <asp:Panel ID="Panel2" runat="server" BorderColor="Red" BorderStyle="Inset" 
                    Width="169px">
                    <asp:CheckBox ID="chkMashine" runat="server" Font-Bold="True" 
                        Text="Answering Machine" AutoPostBack="True" 
                        oncheckedchanged="chkMashine_CheckedChanged" /><br />
                    <asp:CheckBox ID="chkCalculator" runat="server" Font-Bold="True" 
                        Text="Calculator" AutoPostBack="True" 
                        oncheckedchanged="chkCalculator_CheckedChanged" /><br />
                    <asp:CheckBox ID="chkCopy" runat="server" Font-Bold="True" 
                        Text="Copy Mashine" AutoPostBack="True" 
                        oncheckedchanged="chkCopy_CheckedChanged" />

                </asp:Panel>
            </td>
            <td align="center">
                <asp:DropDownList ID="drPayment" runat="server" Font-Bold="True" Height="16px" 
                    Width="97px" AutoPostBack="True" 
                    onselectedindexchanged="drPayment_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td colspan="2">
                <asp:Image ID="img3" runat="server" Height="95px" Width="105px" 
                    ImageAlign="Middle" ImageUrl="sample.svg" />
                <asp:Image ID="img4" runat="server" Height="95px" Width="105px" 
                    ImageAlign="Middle" ImageUrl="sample.svg" />
            </td>
            <td align="center">
                <asp:Label ID="lblDate" runat="server" Text="Label" Font-Bold="True" 
                    Font-Size="X-Large" ForeColor="#3333FF"></asp:Label> </td>
        </tr>

        <tr>
            <td align="center">
                <asp:Button ID="btnOrder" runat="server" Text="Order" Width="79px" 
                    onclick="btnOrder_Click" /><br />
                <asp:Button ID="btnClear" runat="server" Text="Clear" Width="79px" 
                    onclick="btnClear_Click" />          
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Main Computer:" Font-Bold="True" 
                    ForeColor="#CC0000" BackColor="#99FF33"></asp:Label>
                <asp:Label
                    ID="lblcomp" runat="server" Text="Pc" Font-Bold="True"></asp:Label>
                    <br />

                     <asp:Label ID="Label2" runat="server" Text="Option A:" Font-Bold="True" 
                    ForeColor="#CC0000" BackColor="#99FF33"></asp:Label>
                <asp:Label
                    ID="lblop1" runat="server" Text="---" Font-Bold="True"></asp:Label>
                    <br />

                     <asp:Label ID="Label3" runat="server" Text="Option B:" Font-Bold="True" 
                    ForeColor="#CC0000" BackColor="#99FF33"></asp:Label>
                <asp:Label
                    ID="lblop2" runat="server" Text="---" Font-Bold="True"></asp:Label>
                    <br />

                        <asp:Label ID="Label4" runat="server" Text="Option C:" Font-Bold="True" 
                    ForeColor="#CC0000" BackColor="#99FF33"></asp:Label>
                <asp:Label
                    ID="lblop3" runat="server" Text="---" Font-Bold="True"></asp:Label>
                    <br />

                        <asp:Label ID="Label5" runat="server" Text="Extra Component" Font-Bold="True" 
                    ForeColor="#CC0000" BackColor="#99FF33"></asp:Label>
                <asp:Label
                    ID="lblextra" runat="server" Text="---" Font-Bold="True"></asp:Label>
                    <br />

                        <asp:Label ID="Label6" runat="server" Text="Payment" Font-Bold="True" 
                    ForeColor="#CC0000" BackColor="#99FF33"></asp:Label>
                <asp:Label
                    ID="lblpay" runat="server" Text="U.S Dollars" Font-Bold="True"></asp:Label>
                    <br />
            </td>

            <td>
                <asp:Image ID="img5" runat="server" Height="95px" Width="105px" 
                    ImageUrl="sample.svg" />
            </td>
            <td>
                <asp:Image ID="img6" runat="server" Height="95px" Width="105px" 
                    ImageUrl="sample.svg" /></td>
        </tr>
    </table>
    
  
    </form>
    </center>
</body>
</html>
