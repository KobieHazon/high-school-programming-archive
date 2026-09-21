using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kobie_Calc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double x = double.Parse(TextBox1.Text);
        double y = double.Parse(TextBox2.Text);

        if (RadioButtonList1.Items[0].Selected == true)
        {
            Label2.Text = (x + y).ToString();
        }
        if (RadioButtonList1.Items[1].Selected == true)
        {
            Label2.Text = (x - y).ToString();
        }
        if (RadioButtonList1.Items[2].Selected == true)
        {
            Label2.Text = (x * y).ToString();
        }
        if (RadioButtonList1.Items[3].Selected == true)
        {
            Label2.Text = (x / y).ToString();
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
