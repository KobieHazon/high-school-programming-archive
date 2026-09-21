using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Store : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Page.IsPostBack == false)
        {
            lstItems.Items.Add("Extra Hard Disk");
            lstItems.Items.Add("Printer");
            lstItems.Items.Add("Satelite Dish");          

            drPayment.Items.Add("U.S Dollars");
            drPayment.Items.Add("Check");
            drPayment.Items.Add("Credit Card");

            if (Session["Order"] == null)
            {
                rdbPc.Checked = true;

                ca.SelectedDate = System.DateTime.Today;

                lblDate.Text = System.DateTime.Today.ToShortDateString();
            }
            else
            {
                Order myOldOrder = (Order)Session["Order"];

                string compChoice = myOldOrder.MainComputer;

                if (compChoice.Equals("Pc"))
                {
                    rdbPc.Checked = true;
                    img1.ImageUrl = "~/sample.svg";
                    lblcomp.Text = "Pc";
                }
                else if (compChoice.Equals("Machintosh"))
                {
                    rdbMac.Checked = true;
                    img1.ImageUrl = "~/sample.svg";
                    lblcomp.Text = "Machintosh";

                }
                else
                {
                    rdbLapTop.Checked = true;
                    img1.ImageUrl = "~/sample.svg";
                    lblcomp.Text = "LapTop";
                }
                if (myOldOrder.OfficeStuff[0].Equals("---") == false)
                {
                    chkMashine.Checked = true;
                    img2.ImageUrl = "~/sample.svg";
                    lblop1.Text = "Answering Machine";
                }
                if (myOldOrder.OfficeStuff[1].Equals("---") == false)
                {
                    chkCalculator.Checked = true;
                    img4.ImageUrl = "~/sample.svg";
                    lblop2.Text = "Calculator";
                }
                if (myOldOrder.OfficeStuff[2].Equals("---") == false)
                {
                    chkCopy.Checked = true;
                    img6.ImageUrl = "~/sample.svg";
                    lblop3.Text = "Copy Machine";
                }
                bool found = false;
                int index = 0;

                while (found == false && index < 3 )
                {
                    if (lstItems.Items[index].Text.Equals(myOldOrder.Extra.ToString()))
                    {
                        lstItems.SelectedIndex = index;
                        if (index == 0)
                        {
                            img3.ImageUrl = "~/sample.svg";
                            lblextra.Text = "Hard Disk";
                        }
                        else if (index == 1)
                        {
                            img3.ImageUrl = "~/sample.svg";

                            lblextra.Text = "Printer";
                        }
                        else
                        {
                            img3.ImageUrl = "~/sample.svg";

                            lblextra.Text = "Satelite Dish";
                        }
                        found = true;
                    }
                    index++;
                }

                lblDate.Text = myOldOrder.Date;

                ca.SelectedDate = System.Convert.ToDateTime(myOldOrder.Date);

                lblpay.Text = myOldOrder.Money;

                string mymoney = lblpay.Text;

                switch (mymoney)
                {
                    case "U.S Dollars":
                        drPayment.SelectedIndex = 0;
                        img5.ImageUrl = "~/sample.svg";
                        break;
                    case "Check":
                        drPayment.SelectedIndex = 1;
                        img5.ImageUrl = "~/sample.svg";
                        break;
                    case "Credit Card":
                        drPayment.SelectedIndex = 2;
                        img5.ImageUrl = "~/sample.svg";
                        break;

                }
               


            }


            
        }
    }
    protected void ca_SelectionChanged(object sender, EventArgs e)
    {
        lblDate.Text = ca.SelectedDate.ToShortDateString();
    }
    protected void rdbPc_CheckedChanged(object sender, EventArgs e)
    {
        img1.ImageUrl = "~/sample.svg";

        lblcomp.Text = "Pc";
    }
    protected void rdbMac_CheckedChanged(object sender, EventArgs e)
    {
        img1.ImageUrl = "~/sample.svg";

        lblcomp.Text = "Machintosh";
    }
    protected void rdbLapTop_CheckedChanged(object sender, EventArgs e)
    {
        img1.ImageUrl = "~/sample.svg";

        lblcomp.Text = "LapTop";
    }
    protected void chkMashine_CheckedChanged(object sender, EventArgs e)
    {
        if (chkMashine.Checked == true)
        {
            img2.ImageUrl = "~/sample.svg";
            lblop1.Text = "Answering Machine";
        }
        else
        {
            img2.ImageUrl = "~/sample.svg";
            lblop1.Text = "---";
        }


    }
    protected void chkCalculator_CheckedChanged(object sender, EventArgs e)
    {
        if (chkCalculator.Checked == true)
        {
            img4.ImageUrl = "~/sample.svg";
            lblop2.Text = "Calculator";
        }
        else
        {
            img4.ImageUrl = "~/sample.svg";
            lblop2.Text = "---";
        }
    }
    protected void chkCopy_CheckedChanged(object sender, EventArgs e)
    {
        if (chkCopy.Checked == true)
        {
            img6.ImageUrl = "~/sample.svg";
            lblop3.Text = "Copy Machine";
        }
        else
        {
            img6.ImageUrl = "~/sample.svg";
            lblop3.Text = "---";
        }

    }
    protected void lstItems_SelectedIndexChanged(object sender, EventArgs e)
    {
        int choice = lstItems.SelectedIndex;

        switch (choice)
        {
            case 0:
                img3.ImageUrl = "~/sample.svg";

                lblextra.Text = "Hard Disk";

                break;
            case 1:
                img3.ImageUrl = "~/sample.svg";

                lblextra.Text = "Printer";
                break;
            case 2:
                img3.ImageUrl = "~/sample.svg";

                lblextra.Text = "Satelite Dish";
                break;
        }
    }
    protected void drPayment_SelectedIndexChanged(object sender, EventArgs e)
    {
        int choice = drPayment.SelectedIndex;

        switch (choice)
        {
            case 0:
                img5.ImageUrl = "~/sample.svg";

                lblpay.Text = "U.S Dollars";

                break;
            case 1:
                img5.ImageUrl = "~/sample.svg";

                lblpay.Text = "Check";
                break;
            case 2:
                img5.ImageUrl = "~/sample.svg";

                lblpay.Text = "Credit Card";
                break;
        }
    }
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        string[] arr_office = new string[3];

        arr_office[0] = lblop1.Text;
        arr_office[1] = lblop2.Text;
        arr_office[2] = lblop3.Text;

        Order myOrder = new Order(lblcomp.Text, arr_office, lblextra.Text, lblpay.Text,lblDate.Text);

        Session["Order"] = myOrder;

        Response.Redirect("Recipt.aspx");
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Store.aspx");
    }
}
