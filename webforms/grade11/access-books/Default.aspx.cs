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


        if (dt == arrTables[1])
        {
            LoadImage();
        }
        else
        {
            Txt4.Visible = true;
            Txt5.Visible = true;
            Txt6.Visible = true;
            Image1.Visible = false;
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

            arrTables[0] = DbMethods.DownloadData("SELECT * FROM Clients", "Clients", Server.MapPath("App_Data/Books.mdb"));
            arrTables[1] = DbMethods.DownloadData("SELECT * FROM Books", "Books", Server.MapPath("App_Data/Books.mdb"));
            
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
        LblTable.Text = "You Are Seeing- " + arrTables[0].TableName;
        LblCount.Text = "There Are " + arrTables[0].Rows.Count.ToString() + " entries";

        ShowViewObjects();
        ShowData(arrTables[0]);

    }
    protected void LstTables_SelectedIndexChanged(object sender, EventArgs e)
    {
        RowIndex = 0;

        int index = LstTables.SelectedIndex;
        ShowData(arrTables[index]);
        
        LblTable.Text = "You Are Seeing- " + arrTables[index].TableName;
        LblCount.Text = "There Are " + arrTables[index].Rows.Count.ToString() + " entries";
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
        if (RowIndex< 0)
        {
            RowIndex++;
        }
        else
        {
            ShowData(arrTables[tableIndex]);
        }
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

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            DeleteB.Visible = true;
            lblDelete.Visible = true;
            for (int i = 0; i < DbMethods.DownloadData("SELECT * FROM Clients", "Clients", Server.MapPath("App_Data/Books.mdb")).Rows.Count; i++)
            {
                DataTable Client = DbMethods.DownloadData("SELECT * FROM Clients WHERE Clients.ID= '" + i + "'", "Clients", Server.MapPath("App_Data/Books.mdb"));
                string str = Client.Rows[0][1].ToString();
                if (str != null)
                {
                    DeleteB.Items.Add(str);
                }
                DeleteB.SelectedIndex = 0;
                
            }
            NewAge.Visible = false;
            NewID.Visible = false;
            NewMail.Visible = false;
            NewName.Visible = false;
            NewZip.Visible = false;
            NewPhone.Visible = false;
            lblAdd.Visible = false;
        }
        else
        {
            NewAge.Visible = true;
            NewID.Visible = true;
            NewMail.Visible = true;
            NewName.Visible = true;
            NewZip.Visible = true;
            NewPhone.Visible = true;
            DeleteB.Visible = false;
            lblDelete.Visible = false;
            lblAdd.Visible = true;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            string str = DeleteB.SelectedValue;
            DbMethods.DataUpload("DELETE * FROM CLIENTS WHERE NameC = '" + str + "'", "Clients", Server.MapPath("App_Data/Books.mdb"));
        }
        if (RadioButtonList1.SelectedIndex == 1)
        {
            string query = "INSERT INTO Clients ( ID, Namec, Phone, Age, Email, ZipCode ) VALUES ( '" + NewID.Text.ToString() + "', '" + NewName.Text.ToString() + "', '" + NewPhone.Text.ToString() + "', '" + NewAge.Text.ToString() + "', '" + NewMail.Text.ToString() + "', '" + NewZip.Text.ToString() + "' )";
            DbMethods.DataUpload(query, "Clients", Server.MapPath("App_Data/Books.mdb"));

        }
    }
    private void LoadImage()
    {
        Image1.Visible = true;
        if (Txt1.Text == "0")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "1")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "2")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "3")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "4")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "5")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "6")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "7")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "8")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "9")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        if (Txt1.Text == "10")
        {
            Image1.ImageUrl = "~/sample.svg";
        }
        Txt4.Visible = false;
        Txt5.Visible = false;
        Txt6.Visible = false;
    }

    private void ShowViewObjects()
    {

        BtnBack.Visible = true;
        BtnFirst.Visible = true;
        BtnLast.Visible = true;
        BtnGo.Visible = true;
        Txt1.Visible = true;
        Txt2.Visible = true;
        Txt3.Visible = true;
        Txt4.Visible = true;
        Txt5.Visible = true;
        Txt6.Visible = true;
        lbl1.Visible = true;
        lbl2.Visible = true;
        lbl3.Visible = true;
        lbl4.Visible = true;
        lbl5.Visible = true;
        lbl6.Visible = true;
        Image1.Visible = true;
        LblCount.Visible = true;
        LblTable.Visible = true;
        LstTables.Visible = true;
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
    protected void Txt6_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Txt5_TextChanged(object sender, EventArgs e)
    {

    }
}
