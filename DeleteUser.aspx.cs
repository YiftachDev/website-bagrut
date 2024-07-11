using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(bool)Session["isLogged"])
        {
            Session["message"] = "הנך צריך להתחבר על מנת לגשת לדף זה!";
            Response.Redirect("message.aspx");
        }

        string sqlQuery = "";
        string tableName = "myDB";

        if (Request.Form["submit"] != null)
        {
            sqlQuery = String.Format("DELETE FROM {0} WHERE id1 = '{1}'", tableName, Session["id"]);
            MyAdoHelperAccess.DoQuery(sqlQuery);
            Session["message"] = "המשתמש נמחק בהצלחה";
            Response.Redirect("message.aspx");
        }
    }
}