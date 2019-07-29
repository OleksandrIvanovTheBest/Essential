using System;

namespace StaticClasses
{
    internal static class Calculator
    {
        public static double CalculateSum(this double a, double b)
        {
            return a + b;
        }

        public static double CalculateDiff(this double a, double b)
        {
            return a - b;
        }

        public static double CalculateMultiple(this double a, double b)
        {
            return a * b;
        }

        public static double CalculateDivision(this double a, double b)
        {
            if (b == 0)
                return Double.NaN;
            else
                return a / b;
        }
    }
}
