using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //4
    internal class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
