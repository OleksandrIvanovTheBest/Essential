using System;

namespace Events
{
    internal static class Calculator
    {
        public static double Add(this double a, double b)
        {
            return a + b;
        }

        public static double Sub(this double a, double b)
        {
            return a - b;
        }

        public static double Mul(this double a, double b)
        {
            return a * b;
        }

        public static double Div(this double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                return Double.NaN;
            }
        }
    }
}
