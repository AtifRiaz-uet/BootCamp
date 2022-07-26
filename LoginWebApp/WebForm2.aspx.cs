using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginWebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                user.Text = Session["user"].ToString();
            }

            if (Session["user"] == null)
            {
                Response.Redirect("WebForm1.aspx");
            }


        }
        protected void logout(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("WebForm1.aspx");
        }
    }
}