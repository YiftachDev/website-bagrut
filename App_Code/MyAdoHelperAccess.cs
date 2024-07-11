using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;
using System.Xml;
using System.IO; //XML - ����� ������ �����

/// <summary>
/// Summary description for MyAdoHelper
/// ������ ��� ������ ���� ������ ���� ����
///  App_Data ���� ����� ����� 
/// </summary>

public class MyAdoHelperAccess
{
    public MyAdoHelperAccess()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static OleDbConnection ConnectToDb()
    {
        //string fileName = "xxx/mdf"; //�� �����
        //string fileName = "DB.mdb";   //�� �����
        string fileName = "Database1.accdb";   //�� �����

        string path = HttpContext.Current.Server.MapPath("App_Data/");//����� ��� ���������
        path += fileName;
        //string path = HttpContext.Current.Server.MapPath("App_Data/" + fileName);//���� �� ����� ��� ������� ������ ��� ������ �� ����� ����
        //string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + path;//����� �������� ������� ����� ���� ����
        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + path;//����� �������� ������� ����� ���� ����

        OleDbConnection conn = new OleDbConnection(connString);
        return conn;
    }

    /// <summary>
    /// To Execute update / insert / delete queries
    ///  ������ ����� �� ���� ����� ������ ������ �� ������ �� ����
    /// </summary>

    public static void DoQuery(string sql)//������ ����� �� ��� ������ ������� �����/ �����/ �����
    //������ �� ������ �� ���� �����
    {
        OleDbConnection conn = ConnectToDb();
        conn.Open();  //����� �����
        OleDbCommand com = new OleDbCommand(sql, conn);
        com.ExecuteNonQuery();  //����� ����� ����� �������
        com.Dispose();      //����� ������
        conn.Close();       //����� �����
    }

    /// <summary>
    /// To Execute update / insert / delete queries
    ///  ������ ����� �� ���� ����� ������ ������� �� ���� ������ ������� ������ ������
    /// </summary>
    public static int RowsAffected(string sql)
    //������ ����� ����� ��� ������ ������ �����
    //������ �� ������ �� ���� �����
    {
        OleDbConnection conn = ConnectToDb();
        conn.Open();
        OleDbCommand com = new OleDbCommand(sql, conn);
        int rowsA = com.ExecuteNonQuery();
        conn.Close();
        return rowsA;
    }


    /// <summary>
    /// ������ ����� �� ���� ����� ������ ��� - ������ ��� �� ���� ���� ���� ����
    /// </summary>
    public static bool IsExist(string sql)
    //������ ����� �� ���� ����� ����� ���� ������� ��� �� ������� ������ ���� ����
    {
        //ConnectToDb - ���� ����� ����� ������
        OleDbConnection conn = ConnectToDb();
        conn.Open();
        OleDbCommand com = new OleDbCommand(sql, conn);
        OleDbDataReader data = com.ExecuteReader(); //����� �����
        bool found;
        // �� �� ������ ������ ���� ��� ���� ��� - ���� ���� ���� �������
        found = (bool)data.Read();
        conn.Close();
        return found;
    }


    public static DataTable ExecuteDataTable(string sql)
    {
        OleDbConnection conn = ConnectToDb();
        conn.Open();

        //DataTable -����� �������
        //sql -����� ���� ������ �������� ������
        //������ - DataAdapter
        //1. ���� ���� ����
        //2. ������� ��������� DataTable �� Fill �����
        //3. ����� ������ ���� ������ �� ������
        OleDbDataAdapter tableAdapter = new OleDbDataAdapter(sql, conn);
        DataTable dt = new DataTable(); //DataTable- ����� ���� �� �������
        tableAdapter.Fill(dt);
        return dt; //DataTable - ����� ���� �������
    }

    public void ExecuteNonQuery(string sql)
    {
        OleDbConnection conn = ConnectToDb();
        conn.Open();
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    //������ ����� ���� ����� ���� ������� 
    //������ ������ ���� �� �� ����� ������ ������    
    //public static string PrintDataTable(string sql)
    //{
    //    //����� ������� ��"� DataTable ����� ������ �
    //    DataTable dt = ExecuteDataTable(sql);

    //    string printStr = "<table border='1'>"; //HTML ����� ���� �������

    //    foreach (DataRow row in dt.Rows) //dt ����� ����� �����
    //    {
    //        printStr += "<tr>";
    //        //foreach ����� ������
    //        //������ ����� ������ �� ��������
    //        //�� �� ��� ����� ���� ���� �������
    //        //HTML -������ ������ ������ ���� �
    //        foreach (object myItemArray in row.ItemArray)
    //        {
    //            //���� ������ ����� - ItemArray  �����
    //            printStr += "<td>" + myItemArray.ToString() +"</td>";
    //        }
    //        printStr += "</tr>";
    //    }
    //    printStr += "</table>";
    //    return printStr;
    //}

    public static string PrintDataTable(string sql)
    {
        //����� ������� ��"� DataTable ����� ������ �
        DataTable dt = ExecuteDataTable(sql);
        string bgcolor;
        string manager_m;
        bool color = false;
        string str = "";
        foreach (DataRow row in dt.Rows)
        {
            if (color)
                bgcolor = " bgcolor='#fbfbfb'";
            else
                bgcolor = " bgcolor='#ffffce'";

            if ((bool)row["manager"])
                manager_m = "��";
            else
                manager_m = "��";

            str += "<tr" + bgcolor + ">";
            str += "<td>" + row["userID"] + "</td>";
            str += "<td>" + row["uName"] + "</td>";
            str += "<td>" + row["fName"] + " " + row["lName"] + "</td>";
            str += "<td>" + row["eMail"] + "</td>";
            str += "<td>" + row["pas"] + "</td>";
            str += "<td>" + row["gender"] + "</td>";
            str += "<td>" + row["city"] + "</td>";
            str += "<td>" + row["yearBirth"] + "</td>";
            str += "<td>" + row["hobby"] + "</td>";
            str += "<td>" + manager_m + "</td>";
            str += "</tr>";
            color = !color;
        }
        return str;
    }

    public static DataTable GetFullTable(string tbl)
    {

        return GetTable("select * from " + tbl);
    }

    public static DataTable GetTable(string sqlStr)
    {
        OleDbConnection con = MyAdoHelperAccess.ConnectToDb();
        OleDbCommand cmd = new OleDbCommand(sqlStr, con);

        DataTable dt = new DataTable();
        OleDbDataAdapter adp = new OleDbDataAdapter();
        adp.SelectCommand = cmd;

        adp.Fill(dt);
        return dt;
    }




    //XML - ����� �����
    //������ �� �������
    public static XmlDocument XmlDocumentReturn(string xmlFile)
    {
        string path = HttpContext.Current.Server.MapPath("App_Data/");// ����� ���� ������
        path += xmlFile;

        XmlDocument doc = new XmlDocument(); // ����� ������� XML
        doc.Load(path); // ����� ���� ������
        return doc;
    }

    //XML - ����� ����� ����� 
    public static bool InsertReport(string xmlFile, string user, string date, string content)
    { // ������ ����� �� �����, ����� ����� ���� ������� ����

        XmlElement reportEle, userEle, dateEle, contentEle;
        XmlDocument doc = new XmlDocument(); // ����� ������� XML

        string path = HttpContext.Current.Server.MapPath("App_Data/");// ����� ���� ������
        path += xmlFile;

        doc.Load(path); // ����� ���� ������
        userEle = doc.CreateElement("user"); // ����� ��� ������
        dateEle = doc.CreateElement("date"); // ����� ��� ������
        contentEle = doc.CreateElement("content"); // ����� ��� �����
        reportEle = doc.CreateElement("report"); // ����� ��� ������
        userEle.InnerText = user; // ����� ���� ������ ������
        dateEle.InnerText = date; // ����� ���� ������ ������
        contentEle.InnerText = content; // ����� ���� ������ �����
        reportEle.AppendChild(userEle); // ����� ����� ������ �����
        reportEle.AppendChild(dateEle); // ����� ����� ������ �����
        reportEle.AppendChild(contentEle); // ����� ����� ����� �����
        doc.DocumentElement.InsertBefore(reportEle, doc.DocumentElement.FirstChild); // ����� ����� ������ �����
        FileStream fsxml = new FileStream(path, FileMode.Truncate,
                                  FileAccess.Write,
                                  FileShare.ReadWrite);
        doc.Save(fsxml);
        fsxml.Close();//���� ����� �� ����� 
        return true;
    }


}

