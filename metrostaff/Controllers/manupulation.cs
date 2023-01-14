/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metrostaff;
using Org.BouncyCastle.Asn1.Mozilla;*/

namespace metrostaff.Controllers
{
    internal class Manupulation
    {
        public double getLargestAxis(double first, double second, double third)
        {
            if (first > second)
            {
                //4
                if (first > third)
                {
                    return first;
                }
                else
                {
                    return third;
                }
            }
            else
            {
                if (second > third)
                {
                    return second;
                }
                else
                {
                    return third;
                }
            }
        }
        public double GetRandomAxis(double length)
        {
            Random axis = new Random();
           return axis.NextDouble() * length;
        }
        public double ConvertedAxisToDouble(string axisValue)
        {
            return Convert.ToDouble(axisValue);
        }
    }
}
