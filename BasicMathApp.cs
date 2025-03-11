using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathApp
{
    public class BasicMath
    {
        // private properties
        private double num1;
        private double num2;

        // constructor
        public BasicMath(double num1 = 0, double num2 = 0)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        // readonly properties
        public double Num1 { get { return num1; } }
        public double Num2 { get { return num2; } }

        // public methods
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }// class
}// namespace
    