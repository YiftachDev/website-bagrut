using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username;
        string password;
        string email;
        string id;
        int birthYear = 0;
        string gender;
        string favoriteSport;
        string verify;

        string sqlQuery = "";
        string tableName = "myDB";

        if (Request.Form["submit"] != null)
        {
            username = Request.Form["username"];
            password = Request.Form["password1"];
            email = Request.Form["email"];
            id = Request.Form["id1"];
            gender = Request.Form["gender"];
            favoriteSport = Request.Form["favoriteSport"];
            verify = Request.Form["verify"];

            sqlQuery = String.Format("SELECT * FROM {1} WHERE username = '{0}'", username, tableName);
            if (MyAdoHelperAccess.IsExist(sqlQuery))
            {
                Session["message"] = "פרטים אלה כבר בשימוש!";
                Response.Redirect("message.aspx");
            }

            if (string.IsNullOrEmpty(username))
            {
                Session["message"] = "שם משתמש ריק, אנא מלא אותו";
                Response.Redirect("message.aspx");
            }

            if (string.IsNullOrEmpty(password))
            {
                Session["message"] = "סיסמה ריקה, אנא מלא אותה";
                Response.Redirect("message.aspx");
            }

            if (string.IsNullOrEmpty(email))
            {
                Session["message"] = "כתובת אימייל ריקה, אנא מלא אותה";
                Response.Redirect("message.aspx");
            }

            if (string.IsNullOrEmpty(Request.Form["birthYear"]))
            {
                Session["message"] = "שנת הלידה ריקה, אנא מלא אותה";
                Response.Redirect("message.aspx");
            }

            if (string.IsNullOrEmpty(id))
            {
                Session["message"] = "תעודת זהות ריקה, אנא מלא אותה";
                Response.Redirect("message.aspx");
            }

            else if (!id.All(char.IsDigit))
            {
                Session["message"] = "תעודת הזהות צריכה להיות מספר";
                Response.Redirect("message.aspx");
            }

            if (Request.Form["birthYear"].ToString() != "")
            {
                birthYear = int.Parse(Request.Form["birthYear"]);
            }
            else
            {
                Session["message"] = "שנת הלידה ריקה, מלא אותה";
                Response.Redirect("message.aspx");
            }

            if (string.IsNullOrEmpty(favoriteSport))
            {
                Session["message"] = "ספורט אהוב ריק, אנא מלא/י אותו";
                Response.Redirect("message.aspx");
            }

            if (string.IsNullOrEmpty(gender))
            {
                Session["message"] = "מגדר ריק, אנא בחר/י אופציה";
                Response.Redirect("message.aspx");
            }

            if (string.IsNullOrEmpty(verify))
            {
                Session["message"] = "אנא לחץ על כפתור אימות";
                Response.Redirect("message.aspx");
            }

            sqlQuery = string.Format("INSERT INTO {0} (username, password1, email, id1, birthYear, gender, favoriteSport) VALUES ('{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}')", tableName, username, password, email, id, birthYear, gender, favoriteSport);

            MyAdoHelperAccess.DoQuery(sqlQuery);
            Response.Redirect("Login.aspx");
                
        }
    }
}