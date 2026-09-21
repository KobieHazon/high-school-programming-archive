using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.Items[0].Selected)
        {
            Image1.ImageUrl = "~/sample.svg";
            Label1.Text = "Ray and his Dad";
        }
        if (RadioButtonList1.Items[1].Selected)
        {
            Image1.ImageUrl = "~/sample.svg";
            Label1.Text = "Sexy Ray";
        }
        if (RadioButtonList1.Items[2].Selected)
        {
            Image1.ImageUrl = "~/sample.svg";
            Label1.Text = "Beautiful Ray";
        }

    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ListBox1.Items[0].Selected)
        {
            Image1.ImageUrl = "~/sample.svg";
            Label1.Text = "Ray and his Dad"; 
        }
        if (ListBox1.Items[1].Selected)
        {
            Image1.ImageUrl = "~/sample.svg";
            Label1.Text = "Sexy Ray";
        }
                if (ListBox1.Items[2].Selected)
        {
            Image1.ImageUrl = "~/sample.svg";
            Label1.Text = "Beautiful Ray";
        }

    }
}
