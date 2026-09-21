<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style4
        {
            height: 50px;
        }
        .style1
        {
            width: 206px;
            height: 50px;
        }
        .style3
        {
            width: 206px;
            height: 70px;
        }
        .style5
        {
            width: 206px;
            height: 319px;
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
        .style12
        {
            height: 319px;
        }
        .style13
        {
            width: 208px;
            height: 50px;
        }
        .style14
        {
            width: 208px;
            height: 70px;
        }
        .style15
        {
            width: 208px;
            height: 33px;
        }
        .style16
        {
            width: 208px;
            height: 319px;
        }
        </style>
</head>
<body>
   <center style="background-image: url('sample.svg')">
   <h1 style="color:#006600; font-size: 52px; font-weight: 700; text-decoration: underline blink;"> Book Store Managment</h1>
       <p style="color:#800080; font-size: x-large; font-weight: bold;"> Edit Mode</p>
       <form id="form1" runat="server">
       <p style="color:#800000"> What do you want to do:
           <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
               onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
               ForeColor="Maroon">
               <asp:ListItem>Delete</asp:ListItem>
               <asp:ListItem>Add</asp:ListItem>
           </asp:RadioButtonList>
           <asp:Label ID="lblDelete" runat="server" Text="Who do you want to delete?" 
               Visible="False" ForeColor="Maroon"></asp:Label>
           <asp:Label ID="lblAdd" runat="server" Text="Enter the data for new client:" 
               ForeColor="Maroon" Visible="False"></asp:Label>
       </p>
       <p style="color:Aqua"> 
           <asp:ListBox ID="DeleteB" runat="server" Visible="False"></asp:ListBox>
       </p>
       <p style="color:Aqua"> 
           <asp:TextBox ID="NewID" runat="server" Visible="False">Enter ID</asp:TextBox>
           <asp:TextBox ID="NewName" runat="server" Visible="False">Enter Name</asp:TextBox>
           <asp:TextBox ID="NewPhone" runat="server" Visible="False">Enter Phone</asp:TextBox>
           <asp:TextBox ID="NewMail" runat="server" Visible="False">Enter E-Mail</asp:TextBox>
           <asp:TextBox ID="NewAge" runat="server" Visible="False" Width="81px">Enter Age</asp:TextBox>
           <asp:TextBox ID="NewZip" runat="server" Visible="False">Enter ZIP-Code</asp:TextBox>
       </p>
       <p style="color:Aqua"> 
           <asp:Button ID="RedButton" runat="server" Height="32px" onclick="Button1_Click" 
               Text="Do It!" Width="107px" />
       </p>
       <p style="color:#800080; #800080: ;"> 
           ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~</p>
       <p style="color:#800080; font-weight: bold; font-size: x-large;"> View Mode&nbsp; </p>
    <table style="height: 565px; width: 713px;">
    <tr>
    <td class="style13" style="color: #333399" >
        &nbsp;<asp:Label ID="LblTable" runat="server" Text="Label" Visible="False" 
            ForeColor="#333399" Font-Bold="True"></asp:Label>
        
    </td>
    <td class="style1">
        <asp:Label ID="lbl1" runat="server" Text="Label" Visible="False" 
            ForeColor="#333399" Font-Bold="True"></asp:Label><br /> 
        <asp:Label ID="lbl2" runat="server" Text="Label" Visible="False" 
            ForeColor="#333399" Font-Bold="True"></asp:Label></td>
    <td class="style4">
        <asp:TextBox ID="Txt1" runat="server" ontextchanged="Txt1_TextChanged" 
            Visible="False" ForeColor="#333399" Font-Bold="True"></asp:TextBox> <br />  
        <asp:TextBox ID="Txt2" runat="server" ontextchanged="Txt2_TextChanged" 
            Visible="False" ForeColor="#333399" Font-Bold="True"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td class="style14" >
        <asp:ListBox ID="LstTables" runat="server" Height="94px" Width="93px" 
            AutoPostBack="True" 
            onselectedindexchanged="LstTables_SelectedIndexChanged" Visible="False" 
            ForeColor="#333399" Font-Bold="True"></asp:ListBox>
    </td>
    <td class="style3">
    <asp:Label ID="lbl3" runat="server" Text="Label" Visible="False" 
            ForeColor="#333399" Font-Bold="True"></asp:Label> <br />
     <asp:Label ID="lbl4" runat="server" Text="Label" Visible="False" 
            ForeColor="#333399" Font-Bold="True"></asp:Label> <br />
     <asp:Label ID="lbl5" runat="server" Text="Label" Visible="False" 
            ForeColor="#333399" Font-Bold="True"></asp:Label>
        </td>
        <td>
        <asp:TextBox ID="Txt3" runat="server" ontextchanged="Txt3_TextChanged" 
                Visible="False" ForeColor="#333399" Font-Bold="True"></asp:TextBox><br />
          <asp:TextBox ID="Txt4" runat="server" ontextchanged="Txt4_TextChanged" 
                Visible="False" ForeColor="#333399" Font-Bold="True"></asp:TextBox> <br />
           <asp:TextBox ID="Txt5" runat="server" ontextchanged="Txt5_TextChanged" 
                Visible="False" ForeColor="#333399" Font-Bold="True"></asp:TextBox>

        </td>
        
    </tr>
    <tr>
    <td class="style15"> 
        <asp:Label ID="LblCount" runat="server" Text="Label" Visible="False" 
            ForeColor="#333399" Font-Bold="True"></asp:Label></td>
        <td class="style10"> 
            <asp:Label ID="lbl6" runat="server" Text="Label" Visible="False" 
                ForeColor="#333399" Font-Bold="True"></asp:Label></td>
            <td class="style11"> 
                <asp:TextBox ID="Txt6" runat="server" ontextchanged="Txt6_TextChanged" 
                    Visible="False" Width="168px" ForeColor="#333399" Font-Bold="True"></asp:TextBox></td>
      
    </tr>
 <tr>
 <td class="style16">
     <asp:Button ID="BtnConnect" runat="server" Text="Connect" 
         onclick="BtnConnect_Click" />
 </td>
 <td align="center" class="style5" dir="ltr" rowspan="2">
     <asp:Image ID="Image1" runat="server" Height="290px" Visible="False" 
         Width="258px" ImageAlign="Left" style="margin-left: 0px" />
     <br />
 </td>
 <td align="char" class="style12" dir="ltr" rowspan="2">
     <asp:Button ID="BtnBack" runat="server" Text="<" Height="52px" Width="50px" 
         onclick="BtnBack_Click" Visible="False" />
     <asp:Button ID="BtnGo" runat="server" Text=">" Height="52px" Width="50px" 
         onclick="BtnGo_Click" Visible="False" />
     <br />
     <asp:Button ID="BtnFirst" runat="server" Text="<<" onclick="BtnFirst_Click" 
         Height="52px" Width="50px" Visible="False" />
     <asp:Button ID="BtnLast" runat="server" Text=">>" onclick="BtnLast_Click" 
         Height="52px" Width="50px" Visible="False" />
 </td>
 </tr>
    </table>
    </form>
   
   </center>
</body>
</html>
