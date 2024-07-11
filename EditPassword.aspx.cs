using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public string msg = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(bool)Session["isLogged"])
        {
            Session["message"] = "הנך צריך להתחבר על מנת לגשת לדף זה!";
            Response.Redirect("message.aspx");
        }
        string tableName = "myDB";

        if (Request.Form["submitEdit"] != null)
        {
            string uNameEdit = Request.Form["uNameEdit"];
            string oldPassEdit_o = Request.Form["oldPassEdit"];
            string newPassEdit_o = Request.Form["newPassEdit"];
            string newPassConfirmEdit_o = Request.Form["newPassConfirmEdit"];

            string checkSQL = "SELECT * FROM " + tableName + " WHERE username = '" + uNameEdit + "' AND password1 = '" + oldPassEdit_o + "'";
            if (Request.Form["newPassEdit"] == Request.Form["newPassConfirmEdit"])
            {
                if (MyAdoHelperAccess.IsExist(checkSQL))
                {
                    string updateSQL = "UPDATE " + tableName + " SET password1 = '" + newPassEdit_o + "' WHERE username = '" + uNameEdit + "'";
                    MyAdoHelperAccess.DoQuery(updateSQL);
                    msg = "סיסמה עודכנה בהצלחה!";
                }
                else
                {
                    msg = "שם משתמש או סיסמה נוכחית אינם נכונים";
                }
            }
            else
            {
                msg = "הסיסמה החדשה אינה אומתה כראוי";
            }

            Session["message"] = msg;
            Response.Redirect("Message.aspx");
        }
    }
}