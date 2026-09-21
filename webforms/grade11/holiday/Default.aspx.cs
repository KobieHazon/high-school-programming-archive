using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    static int counter = 7;
    static bool trigger = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (counter == 0 && trigger == true)
        {
            Label3.Text = "HAPPY ROSH HASHANA " + TextBox1.Text + ", I wish you all the best!.";

            Button1.Enabled = false;
        }
        Button1.Text = "Press Me " + (counter).ToString() + " times";
        counter--;
        if (counter == 0 && trigger == false)
        {
            Button1.Text = "Just kidding, Press 56 times!! (maniac laugh)";
            counter = 56;
            trigger = true;
            
        }
        

        
       
        
        
        
      
    }

}
// לשאול על ויסיבל
