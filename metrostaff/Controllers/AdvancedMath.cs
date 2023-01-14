using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metrostaff.Controllers
{
    //i am using the full path name on the inheritance b.c i need to specify
    // the Math class built in class and the customized class that i created in the dll file
    internal class AdvancedMath : MathOperation.MathF, AdvancedCalculator
    {
        public AdvancedMath() { 
        }
        public double Sin(double oprand) 
        {
            return MathF.Sin(((float)oprand));
        }
        public double Cos(double oprand)
        {
            return MathF.Cos(((float)oprand));
        }
        public double Tan(double oprand)
        {
            return MathF.Tan(((float)oprand));
        }
        public double Asin(double oprand)
        {
            return MathF.Asin(((float)oprand));
        }
        public double Acos(double oprand)
        {
            return MathF.Acos(((float)oprand));
        }
        public double Atan(double oprand)
        {
            return MathF.Atan(((float)oprand));
        }
        public string Fibonacci(int oprand)
        {
            int val1,val2,val3, i;
            val1 = 0;
            val2 = 1;
            string result = val1 + " " + val2 + " ";
            for (i = 2; i < oprand; ++i)
            {
                val3 = val1 + val2;
                result = result + val3 + " ";
                val1 = val2;
                val2 = val3;
            }
            return result;
        }
    }
}
