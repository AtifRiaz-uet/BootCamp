using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(x.Value);
            double num2 = Convert.ToInt32(y.Value);
            double result;
            string ans;

            switch (Oper.SelectedValue)
            {
                case "+":
                    result= num2+num1;
                    Response.Redirect("WebForm2.aspx?ans=" + result);
                    break;
                case "-":
                    result = num1-num2;
                    Response.Redirect("WebForm2.aspx?ans=" + result);
                    break;
                case "x":
                    result= num1*num2;
                    Response.Redirect("WebForm2.aspx?ans=" + result);
                    break;
                case "/":
                    result = num1/num2;
                    Response.Redirect("WebForm2.aspx?ans=" + result);
                    break;
            }

        }
    }
}