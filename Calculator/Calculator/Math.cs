using System;

namespace MathOperation
{
    public class MathF
    {
        public static double Add(double oprand1, double oprand2)
        {
            return oprand1 + oprand2;
        }
        public static double Subtract(double oprand1, double oprand2)
        {
            return oprand1 - oprand2;
        }
        public static double Multiply(double oprand1, double oprand2)
        {
            return oprand1 * oprand2;
        }
        public static double Divide(double oprand1, double oprand2)
        {
            return oprand1 / oprand2;   
        }
        public static double Sqrt(double number)
        {
            return System.Math.Sqrt(number);
        }
        public static double PowerOf(double bas, double power) { 
            return System.Math.Pow(bas, power);
        }
    }
}
