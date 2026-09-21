using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.ObjectModel;

public partial class Default : System.Web.UI.Page
{

    private static Collection<Label> lc = new Collection<Label>();

    private static Collection<TextBox> tc = new Collection<TextBox>();

    private static DataTable[] arrTables = new DataTable[2];

    private static int RowIndex = 0;



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
            lc.Add(lbl1);
            lc.Add(lbl2);
            lc.Add(lbl3);
            lc.Add(lbl4);
            lc.Add(lbl5);
            lc.Add(lbl6);//add collection lable

            tc.Add(Txt1);
            tc.Add(Txt2);
            tc.Add(Txt3);
            tc.Add(Txt4);
            tc.Add(Txt5);
            tc.Add(Txt6);//add collection textbox

            arrTables[0] = DbMethods.DownloadData("SELECT * FROM Clients", "Clients", Server.MapPath("App_Data/Database11.mdb"));
            arrTables[1] = DbMethods.DownloadData("SELECT * FROM Books", "Books", Server.MapPath("App_Data/Database11.mdb"));

        }

        lc[0] = lbl1;
        lc[1] = lbl2;
        lc[2] = lbl3;
        lc[3] = lbl4;
        lc[4] = lbl5;
        lc[5] = lbl6;

        tc[0] = Txt1;
        tc[1] = Txt2;
        tc[2] = Txt3;
        tc[3] = Txt4;
        tc[4] = Txt5;
        tc[5] = Txt6;


    }
    protected void BtnConnect_Click(object sender, EventArgs e)
    {
        BtnConnect.Enabled = false;

        for (int i = 0; i < arrTables.Length; i++)
        {
            LstTables.Items.Add(arrTables[i].TableName);
        }

        LstTables.SelectedIndex = 0;
        LblTable.Text =arrTables[0].TableName;
        LblCount.Text =arrTables[0].Rows.Count.ToString();

        ShowData(arrTables[0]);

    }
    protected void LstTables_SelectedIndexChanged(object sender, EventArgs e)
    {
        RowIndex = 0;

        int index = LstTables.SelectedIndex;
        ShowData(arrTables[index]);

        LblTable.Text =arrTables[index].TableName;
        LblCount.Text =arrTables[index].Rows.Count.ToString();
    }
    protected void BtnGo_Click(object sender, EventArgs e)
    {
        RowIndex++;
        int tableIndex = LstTables.SelectedIndex;
        if (RowIndex >= arrTables[tableIndex].Rows.Count)
        {
            RowIndex--;
        }
        else
        {
            ShowData(arrTables[tableIndex]);
        }
    }
    protected void BtnBack_Click(object sender, EventArgs e)
    {
        RowIndex--;
        int tableIndex = LstTables.SelectedIndex;
        if (RowIndex < 0)
        {
            RowIndex++;
        }
        else
        {
            ShowData(arrTables[tableIndex]);
        }
    }
    protected void Txt1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Txt2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Txt3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Txt4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void BtnLast_Click(object sender, EventArgs e)
    {
        int tableIndex = LstTables.SelectedIndex;

        RowIndex = arrTables[tableIndex].Rows.Count - 1;

        ShowData(arrTables[tableIndex]);


    }
    protected void BtnFirst_Click(object sender, EventArgs e)
    {
        int tableIndex = LstTables.SelectedIndex;

        RowIndex = 0;

        ShowData(arrTables[tableIndex]);

    }
    protected void Txt6_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Txt5_TextChanged(object sender, EventArgs e)
    {

    }

}
