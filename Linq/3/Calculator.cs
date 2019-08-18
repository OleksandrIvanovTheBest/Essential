using System;

namespace Linq
{
    internal class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        public dynamic Diff(dynamic a, dynamic b)
        {
            return a - b;
        }

        public dynamic Multiple(dynamic a, dynamic b)
        {
            return a * b;
        }

        public dynamic Div(dynamic a, dynamic b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            else
                return a / b;
        }
    }
}
