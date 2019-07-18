using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //4
    internal class RedColor : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value); Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
