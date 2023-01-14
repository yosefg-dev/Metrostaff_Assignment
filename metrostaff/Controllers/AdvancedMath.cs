/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace metrostaff.Controllers
{
    internal class AdvancedMath : MathOperation.Math
    {
        int val1, val2; 
        public AdvancedMath(int val1, int val2) {
            this.val1 = val1;
            this.val2 = val2;
        }
        public double sin(double oprand)
        {
            return Math.Sin(oprand);
        }
        public double cos(double oprand)
        {
            return Math.Cos(oprand);
        }
        public double tan(double oprand)
        {
            return Math.Tan(oprand);
        }
        public double asin(double oprand)
        {
            return Math.Asin(oprand);
        }
        public double acos(double oprand)
        {
            return Math.Acos(oprand);
        }
        public double atan(double oprand)
        {
            return Math.Atan(oprand);
        }
        public string fibonacci(int oprand)
        {
            int val3, i;
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
