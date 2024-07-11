using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username; // שם משתמש
        string password; // סיסמא

        string sqlQuery = "";
        string tableName = "myDB";

        if (bool.Parse(Session["isLogged"].ToString()))
        {
            Session["message"] = "אתה כבר מחובר לאתר";
            Response.Redirect("message.aspx");
        }

        if (Request.Form["submit"] != null)
        {
            username = Request.Form["username"].ToString();
            password = Request.Form["password"].ToString();

            sqlQuery = "SELECT * FROM " + tableName + " WHERE username = '" + username + "' AND password1 = '" + password + "'";
            if (MyAdoHelperAccess.IsExist(sqlQuery))
            {
                DataTable table = MyAdoHelperAccess.ExecuteDataTable(sqlQuery);
                Session["username"] = table.Rows[0]["username"];
                Session["password"] = table.Rows[0]["password1"];
                Session["id"] = table.Rows[0]["id1"];
                Session["email"] = table.Rows[0]["email"];
                Session["favoriteSport"] = table.Rows[0]["favoriteSport"];
                Session["gender"] = table.Rows[0]["gender"];
                Session["isAdmin"] = table.Rows[0]["isAdmin"];
                Session["isLogged"] = true;
                Session["message"] = "שלום " + Session["username"] + " התחברת בהצלחה!";
                Session["userLinks"] = "            <a href=\"LogOut.aspx\">התנתק</a>              <a href=\"DeleteUser.aspx\">מחיקת משתמש</a>            <a href=\"SearchUser.aspx\">חיפוש משתמש</a>            <a href=\"EditPassword.aspx\">שינוי סיסמא</a>";
                if ((bool)Session["isAdmin"])
                {
                    Session["adminLinks"] = "                 <a href=\"AdminDeleteUser.aspx\">מחיקת משתמש - מנהל</a>";
                }
                Session["SiginingLinks"] = "";
            }
            else
            {
                Session["message"] = "שם משתמש או סיסמא אינם נכונים";
            }
            Response.Redirect("message.aspx");
        }

    }
}