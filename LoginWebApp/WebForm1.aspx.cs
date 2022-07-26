using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("WebForm2.aspx?");
            }
        }

        protected void login_page(object sender, EventArgs e)
        {
            Session["user"] = username.Text;
            Session["password"] = password.Text;

            Response.Redirect("WebForm2.aspx?");
        }
    }
}