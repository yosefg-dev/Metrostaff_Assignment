using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//basic calculator

namespace Math
{
    internal interface BasicCalculator
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
        double PowerOf(double x, double y);
        double Sqrt(double x, double y);
    }
}
