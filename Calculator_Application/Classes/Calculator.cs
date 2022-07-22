using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator_Application
{
    public class Calculator : iCalculate
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2; ;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2; ;
        }
        public double Multiplication(double num1, double num2)
        {
            return num1 * num2; ;
        }
        public double Division(double num1, double num2)
        {
            return num1 / num2; ;
        }
    }
}