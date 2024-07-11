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
        // Session.Abandon();
        Session["username"] = "";
        Session["password"] = "";
        Session["id"] = "";
        Session["email"] = "";
        Session["favoriteSport"] = "";
        Session["gender"] = "";
        Session["isAdmin"] = false;
        Session["isLogged"] = false;
        Session["userLinks"] = "";
        Session["adminLinks"] = "";
        Session["isNew"] = true;
        Response.Redirect("Default.aspx");
    }
}