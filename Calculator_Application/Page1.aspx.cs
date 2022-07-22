using Calculator_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator_Application
{
    public partial class Page1 : System.Web.UI.Page
    {
        iCalculate _calculator;
        protected void Page_Load(object sender, EventArgs e)
        {
            _calculator = new Calculator();
        }

        string answer;
        string strOperation;
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            
            {
                double number1 = Convert.ToInt32(num1.Value);
                double number2 = Convert.ToInt32(num2.Value);

                switch (operation.SelectedValue)
                {
                    case "+":
                        answer = Convert.ToString(_calculator.Add(number1, number2));
                        strOperation = "Addition";
                        break;
                    case "-":
                        answer = Convert.ToString(_calculator.Subtract(number1, number2));
                        strOperation = "Subtraction";
                        break;
                    case "x":
                        answer = Convert.ToString(_calculator.Multiplication(number1, number2));
                        strOperation = "Multiplication";
                        break;
                    case "/":
                        answer = Convert.ToString(_calculator.Division(number1, number2));
                        strOperation = "Division";
                        break;
                }
                Response.Redirect("page2.aspx?X="+number1+"&Y="+number2+"&operation="+strOperation+"&Answer="+ answer);

            }
        }
    }
}