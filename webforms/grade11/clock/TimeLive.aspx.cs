using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TimeLive : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            lblTime.Text = DateTime.Now.ToString("T");
    }

    protected void tmrUpdate_Tick(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToString("T");
    }
}
