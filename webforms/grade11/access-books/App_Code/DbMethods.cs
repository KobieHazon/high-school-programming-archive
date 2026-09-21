using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for DbMethods
/// </summary>
public class DbMethods
{
    private static OleDbConnection connection = null;

    private static void ConnectMe(string DbPosition_Name)
    {
        string ConnectionStr = @"Provider= Microsoft.Jet.OleDb.4.0; Data Source = " + DbPosition_Name;
        connection = new OleDbConnection(ConnectionStr);
    }

    public static DataTable DownloadData(string sql, string TableName, string DbPosition_Name)
    {
        ConnectMe(DbPosition_Name);

        OleDbCommand cmd = new OleDbCommand(sql, connection);

        OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

        DataSet DS = new DataSet();

        DA.Fill(DS, TableName);

        return DS.Tables[0];
    }

    public static void DataUpload(string sql, string TableName, string DbPosition_Name)
    {
        ConnectMe(DbPosition_Name);

        OleDbCommand cmd = new OleDbCommand(sql, connection);

        OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

        DataSet DS = new DataSet();

        DA.Fill(DS, TableName);
    }
}
