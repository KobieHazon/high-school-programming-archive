using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.ObjectModel;

public partial class _Default : System.Web.UI.Page
{
    private static Collection<Label> lc = new Collection<Label>();
    private static Collection<TextBox> tc = new Collection<TextBox>();
    private static DataTable[] arrtables = new DataTable[2];//מערך טבלאות
    private static int RowIndex = 0;// משתנה שנשתמש בו בשביל שורות הטבלה

    private void ShowData(DataTable dt)
    {
        for (int i = 0; i < lc.Count; i++)
        {
            lc[i].Text = string.Empty;
            tc[i].Text = string.Empty;
        }
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            lc[i].Text = dt.Columns[i].ColumnName;
            tc[i].Text = dt.Rows[RowIndex][i].ToString();

        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            lc.Add(Lbl1);
            lc.Add(Lbl2);
            lc.Add(Lbl3);
            lc.Add(Lbl4);
            lc.Add(Lbl5);
            lc.Add(Lbl6);//add collection lable

            tc.Add(Txt1);
            tc.Add(Txt2);
            tc.Add(Txt3);
            tc.Add(Txt4);
            tc.Add(Txt5);
            tc.Add(Txt6);//add collection textbox
            


        }


    }
}
