using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static string p = "Pizza";
    static int changes = 0;
    static bool mbegin = false;
    static bool tbegin = false;
    static bool obegin = false;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.Items[0].Selected)
        {
            Image1.Visible = true;
            Image1.ImageUrl = "~/sample.svg";
        }
        if (RadioButtonList1.Items[1].Selected)
        {
            Image1.Visible = true;
            Image1.ImageUrl = "~/sample.svg";
        }
        if (RadioButtonList1.Items[2].Selected)
        {
            Image1.Visible = true;
            Image1.ImageUrl = "~/sample.svg";
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.Items[0].Selected)
        {
            Image2.Visible = true;
            Image2.ImageUrl = "~/sample.svg";

        }
        if (DropDownList1.Items[1].Selected)
        {
            Image2.Visible = true;
            Image2.ImageUrl = "~/sample.svg";

        }
        if (DropDownList1.Items[2].Selected)
        {
            Image2.Visible = true;
            Image2.ImageUrl = "~/sample.svg";
        }
        if (DropDownList1.Items[3].Selected)
        {
            Image2.Visible = true;
            Image2.ImageUrl = "~/sample.svg";
        }
        if (DropDownList1.Items[4].Selected)
        {
            Image2.Visible = true;
            Image2.ImageUrl = "~/sample.svg";
        }
        if (DropDownList1.Items[5].Selected)
        {
            Image2.Visible = true;
            Image2.ImageUrl = "~/sample.svg";
        }
        if (DropDownList1.Items[6].Selected)
        {
            Image2.Visible = true;
            Image2.ImageUrl = "~/sample.svg";
        }

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (changes == 0)
        {
            Label2.Text = "(Your Pizza Selection)";
        }
        if (CheckBox1.Checked == true)
        {
            if (changes == 0)
            {
                p += " with ";
                tbegin = true;
                obegin = false; mbegin = false;
                
            }
            else
            {
                p += " and ";
            }
            p += "tomatoes";
            Label2.Text = p;
            changes++;
        }
        if (CheckBox1.Checked == false)
        {
            if (p.IndexOf("with tomatoes") != -1)
            {
                tbegin = true;
                obegin = false; mbegin = false;
            }
            if (tbegin == true && changes == 1)
            {
                p = p.Replace(" with tomatoes", "");
            }
            if (tbegin == false)
            {
                p = p.Replace(" and tomatoes", "");
            }
            if (tbegin == true && changes > 1)
            {
                p = p.Replace("tomatoes and ", "");
            }
            Label2.Text = p;
            changes--;
            if (changes == 0)
            {
                Label2.Text = "(Your Pizza Selection)";
                p = "Pizza";
            }
            
        }
    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox2.Checked == true)
        {
            if (changes == 0)
            {
                p += " with ";
                obegin = true;
                tbegin = false; mbegin = false;
            }
            else
            {
                p += " and ";
            }
            p += "olives";
            Label2.Text = p;
            changes++;
        }
        if (CheckBox2.Checked == false)
        {
            if (p.IndexOf("with olives") != -1)
            {
                obegin = true;
                tbegin = false; mbegin = false;
            }
            if (obegin == true && changes == 1)
            {
                p = p.Replace(" with olives", "");
            }
            if (obegin == false)
            {
                p = p.Replace(" and olives", "");
            }
            if (obegin == true && changes > 1)
            {
                p = p.Replace("olives and ", "");
            }
            Label2.Text = p;
            changes--;
            if (changes == 0)
            {
                Label2.Text = "(Your Pizza Selection)";
                p = "Pizza";
            }
            
        }
    }
    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox3.Checked == true)
        {
            if (changes == 0)
            {
                p += " with ";
                mbegin = true;
                obegin = false; tbegin = false;
            }
            else
            {
                p += " and ";
            }
            p += "mushrooms";
            Label2.Text = p;
            changes++;
        }
        if (CheckBox3.Checked == false)
        {
            if (p.IndexOf("with mushroom") != -1)
            {
                mbegin = true;
                obegin = false; tbegin = false;
            }
            if (mbegin == true && changes == 1)
            {
                p = p.Replace(" with mushrooms", "");
            }
            if (mbegin == false)
            {
                p = p.Replace(" and mushrooms", "");
            }
            if (mbegin == true && changes > 1)
            {
                p = p.Replace("mushrooms and ", "");
            }
            Label2.Text = p;
            changes--;
            if (changes == 0)
            {
                Label2.Text = "(Your Pizza Selection)";
                p = "Pizza";
            }
            
        }
    }
}
