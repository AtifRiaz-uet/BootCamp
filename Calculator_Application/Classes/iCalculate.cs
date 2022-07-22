using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator_Application
{
    public interface iCalculate
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiplication(double num1, double num2);
        double Division(double num1, double num2);
    }
}