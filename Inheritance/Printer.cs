using System;

namespace Inheritance
{
    //4
    internal class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
