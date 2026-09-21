using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Recipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            Order myOrder = (Order)Session["Order"];

            if (myOrder != null)
            {

                lblcomp.Text = myOrder.MainComputer;

                string[] arr = myOrder.OfficeStuff;

                string arr_answer = "";

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0 || i == 1)
                    {
                        if (arr[i].Equals("---") == false)
                            arr_answer += arr[i] + ",";
                    }
                    else
                    {
                        if (arr[i].Equals("---") == false)
                            arr_answer += arr[i];
                    }
                }

                lbloffice.Text = arr_answer;

                lblextra.Text = myOrder.Extra;

                lblPay.Text = myOrder.Money;
            }
            else
            {
                lblcomp.Text = "no order";
                lblextra.Text = "no order";
                lbloffice.Text = "no order";
                lblPay.Text = "no payment";
            }
        }

    }
    protected void btnchange_Click(object sender, EventArgs e)
    {
        Response.Redirect("Store.aspx");
    }
}
