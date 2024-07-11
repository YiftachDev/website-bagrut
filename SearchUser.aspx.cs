using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public string strSearch = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(bool)Session["isLogged"])
        {
            Session["message"] = "הנך צריך להתחבר על מנת לגשת לדף זה!";
            Response.Redirect("message.aspx");
        }

        string tableName = "myDB";
        string selectQuery = "";
        DataTable table = null;

        if (Request.Form["search-all"] != null)
        {
            selectQuery = "SELECT * FROM " + tableName;
            table = MyAdoHelperAccess.ExecuteDataTable(selectQuery);
        }

        if (Request.Form["search-by-username"] != null)
        {
            selectQuery = "SELECT * FROM " + tableName + " WHERE username = '" + Request.Form["username"] + "'";
            table = MyAdoHelperAccess.ExecuteDataTable(selectQuery);
        }

        if (Request.Form["search-by-email"] != null)
        {
            selectQuery = "SELECT * FROM " + tableName + " WHERE email = '" + Request.Form["email"] + "'";
            table = MyAdoHelperAccess.ExecuteDataTable(selectQuery);
        }

        if (Request.Form["search-by-gender"] != null)
        {
            selectQuery = "SELECT * FROM " + tableName + " WHERE gender = '" + Request.Form["gender"] + "'";
            table = MyAdoHelperAccess.ExecuteDataTable(selectQuery);
        }


        if (table != null)
        {
            int len = table.Rows.Count;
            if (len > 0)
            {
                strSearch += "<table border=\"1\" style=\"width: 80%\">";
                strSearch += "<tr>";
                strSearch += "<th>שם משתמש</th>";
                strSearch += "<th>מייל</th>";
                strSearch += "<th>מין</th>";
                strSearch += "<th>שנת לידה</th>";
                strSearch += "<th>ספורט אהוב</th>";
                if ((bool)Session["isAdmin"])
                {
                    strSearch += "<th>תעודת זהות</th>";
                    strSearch += "<th>סיסמא</th>";
                    strSearch += "<th>האם מנהל</th>";
                }
                strSearch += "</tr>";

                for (int i = 0; i < len; i++)
                {
                    strSearch += "<tr>";
                    strSearch += "<form method='post' action=''>";
                    strSearch += "<td>" + table.Rows[i]["username"] + "</td>";
                    strSearch += "<td>" + table.Rows[i]["email"] + "</td>";
                    strSearch += "<td>" + table.Rows[i]["gender"] + "</td>";
                    strSearch += "<td>" + table.Rows[i]["birthYear"] + "</td>";
                    strSearch += "<td>" + table.Rows[i]["favoriteSport"] + "</td>";
                    if ((bool)Session["isAdmin"])
                    {
                        strSearch += "<td>" + table.Rows[i]["id1"] + "</td>";
                        strSearch += "<td>" + table.Rows[i]["password1"] + "</td>";
                        strSearch += "<td>" + table.Rows[i]["isAdmin"] + "</td>";
                    }

                    strSearch += "</form>";
                    strSearch += "</tr>";

                    strSearch += "</br>";
                }
                table = null;
                strSearch += "</table>";

            }
        }
    }
}