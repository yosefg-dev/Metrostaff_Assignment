using System;

namespace MathOperation
{
    public class Math
    {
        public double add(double oprand1, double oprand2)
        {
            return oprand1 + oprand2;
        }
        public double subtract(double oprand1, double oprand2)
        {
            return oprand1 - oprand2;
        }
        public double multiply(double oprand1, double oprand2)
        {
            return oprand1 * oprand2;
        }
        public double divide(double oprand1, double oprand2)
        {
            return oprand1 / oprand2;   
        }
        public double sqrt(double number)
        {
            return System.Math.Sqrt(number);
        }
        public double powerOf(double bas, double power) { 
            return System.Math.Pow(bas, power);
        }
    }
}
