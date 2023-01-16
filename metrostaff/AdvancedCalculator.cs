using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metrostaff
{
    internal interface AdvancedCalculator
    {
        double Sin(double x);
        double Cos(double x);
        double Tan(double x);
        double Asin(double x);
        double Acos(double x);
        double Atan(double x);
        string Fibonacci(int x);
    }

}
