using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string counter = "";
    public string userStatus = "";
    public int count = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        string tableName = "enter";
        string selectQuery = "SELECT * FROM " + tableName;
        DataTable table = MyAdoHelperAccess.ExecuteDataTable(selectQuery);
        count = int.Parse(table.Rows[0]["entreis"].ToString());
        // מונה כניסות
        //if (Application["myCount"] == null)
        //{
        //    Application["myCount"] = 0;
        //}
        if (Session["isNew"] == null)
        {
            Session["isNew"] = false;
        }
        //if (bool.Parse(Session["isNew"].ToString()) == false)
        //{
        //    Application["myCount"] = (int)Application["myCount"] + 1;
        //    Session["isNew"] = true;
        //}
        if (bool.Parse(Session["isNew"].ToString()) == false)
        {
            Session["isNew"] = true;
            count++;
            MyAdoHelperAccess.DoQuery(String.Format("UPDATE {0} SET entreis = {1}",tableName, count));
        }
        //counter = Application["myCount"].ToString();

        if (Session["isLogged"] == null || (bool)Session["isLogged"] == false)
        {
            Session["isLogged"] = false;
            userStatus = "שלום אורח";
            Session["SiginingLinks"] = "            <a href=\"SignUp.aspx\">הרשמה</a>          <a href=\"Login.aspx\">התחברות</a>";
        }
        else
        {
            userStatus = "שלום " + Session["username"].ToString();
        }

    }
}
