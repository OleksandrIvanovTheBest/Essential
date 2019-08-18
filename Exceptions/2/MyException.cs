using System;

namespace Exceptions
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
