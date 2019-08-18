using System;

namespace Exceptions
{
    class MyException : Exception
    {
        public void Method()
        {
            Console.WriteLine("Product does not exist");
        }
    }
}
