using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementTask2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void submit(object sender, EventArgs e)
        {
            ViewState["u_name"] = username.Text;
            ViewState["u_pass"] = password.Text;
            HiddenUser.Value = username.Text;
            HiddenPass.Value = password.Text;
            username.Text = string.Empty;
            password.Text = string.Empty;
        }

        protected void Restore_ViewState(object sender, EventArgs e)
        {
            if (ViewState["u_name"] != null)
            {
                username.Text = ViewState["u_name"].ToString();
            }

            if (ViewState["u_pass"] != null)
            {
                password.Text = ViewState["u_pass"].ToString();
            }


        }
        protected void Restore_Hiddenfield(object sender, EventArgs e)
        {
            if (HiddenUser.Value != null)
            {
                username.Text = HiddenUser.Value.ToString();
            }

            if (HiddenPass.Value != null)
            {
                password.Text = HiddenPass.Value.ToString();
            }


        }
    }
}