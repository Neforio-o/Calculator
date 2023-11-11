using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Calc : ICalc
    {
        private double a = 0;

        public void Save_A(double a){this.a = a;}
        public void Clear(){a= 0;}
        public double Multiply(double b){return a * b;}
        public double Division(double b){return a / b;}
        public double Sum(double b){return a + b;}
        public double Subtracrt(double b){return a - b;}
        public double SqrtX(double b){return Math.Pow(a, 1 / b);}
        public double Sqrt(){return Math.Sqrt(a);}
        public double Pow(double b){return Math.Pow(a, b); }
        public double Square(){ return Math.Pow(a, 2.0);}
        public double Factorial()
        {
            double f = 1;
            for (int i = 0; i <= a; i++)
                f *= (double)i;
            return f;

        }
    }
}
