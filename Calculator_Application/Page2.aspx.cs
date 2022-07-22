using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator_Application
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strX = Request["X"];
            Span1.InnerText = strX;
            string strY = Request["Y"];
            Span2.InnerText = strY;
            string strOperation = Request["operation"];
            Span3.InnerText = strOperation;
            string strAnswer = Request["Answer"];
            Answer_page.InnerText = strAnswer;

        }
    }
}