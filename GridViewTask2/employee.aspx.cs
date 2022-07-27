using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewTask2
{
    public partial class employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            name.Text = Request.QueryString["name"].ToString();
            id.Text = Request.QueryString["id"].ToString();
            role.Text = Request.QueryString["role"].ToString();
            salary.Text = Request.QueryString["salary"].ToString();
        }
    }
}