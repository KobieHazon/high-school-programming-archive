using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TextStyle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        Label1.Text = TextBox1.Text;
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml(TextBox2.Text);
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        Label1.BackColor = System.Drawing.ColorTranslator.FromHtml(TextBox3.Text);
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            Label1.Font.Bold = true;
        }
        else if (CheckBox1.Checked == false)
        {
            Label1.Font.Bold = false;
        }
    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox2.Checked == true)
        {
            Label1.Font.Italic = true;
        }
    }
    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox3.Checked == true)
        {
            Label1.Font.Underline = true;
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "Small")
            Label1.Font.Size = FontUnit.Small;
        if (DropDownList1.SelectedValue == "X-small")
            Label1.Font.Size = FontUnit.XSmall;
        if (DropDownList1.SelectedValue == "XX-small")
            Label1.Font.Size = FontUnit.XXSmall;
        if (DropDownList1.SelectedValue == "Medium")
            Label1.Font.Size = FontUnit.Medium;
        if (DropDownList1.SelectedValue == "Large")
            Label1.Font.Size = FontUnit.Large;
        if (DropDownList1.SelectedValue == "X-large")
            Label1.Font.Size = FontUnit.XLarge;
        if (DropDownList1.SelectedValue == "XX-large")
            Label1.Font.Size = FontUnit.XXLarge;
        
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        Label1.Font.Name = TextBox4.Text;
    }
}
