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
        if (Session["isAdmin"] == null || !(bool)Session["isAdmin"])
        {
            Session["message"] = "אינך מנהל!";
            Response.Redirect("message.aspx");
        }

        string sqlQuery = "";
        string tableName = "myDB";
        string id;
        

        if (Request.Form["submit"] != null)
        {
            id = Request.Form["id1"];
            if (!string.IsNullOrEmpty(id))
            {
                //int int_id = int.Parse(id);
                sqlQuery = String.Format("SELECT * FROM {0} WHERE id1 = '{1}'", tableName, id);

            }

            if (MyAdoHelperAccess.IsExist(sqlQuery))
            {
                sqlQuery = String.Format("DELETE FROM {0} WHERE id1 = '{1}'", tableName, id);
                MyAdoHelperAccess.DoQuery(sqlQuery);
                Session["message"] = "המשתמש נמחק בהצלחה";
                Response.Redirect("message.aspx");
            }
            else
            {
                Session["message"] = "המשתמש אינו קיים";
            }
        }    
    }
}