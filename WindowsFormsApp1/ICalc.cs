using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal interface ICalc
    {
        // a - argument_1 b - argument_2
        void Save_A(double a);
        void Clear(); // clear Label
        double Multiply(double b); // *
        double Division(double b); // /
        double Sum(double b); // +
        double Subtracrt(double b); // -
        double SqrtX(double b); // X sqrt y
        double Sqrt(); // sqrt X
        double Square(); // X^2
        double Factorial(); // Facctorial
        double Pow(double b); // X^Y
    }
}
