using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["num"] != null)
            {
                txt.Text = $"{ViewState["num"]}";
            }
            else
            {
                txt.Text = "0";
            }
             
        }
        
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(ViewState["num"]);
            a += 1;
            ViewState["num"] = a;
            txt.Text = $"{ a}";

        }
    }
}