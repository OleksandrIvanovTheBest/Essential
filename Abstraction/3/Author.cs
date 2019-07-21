using System;

namespace Abstraction
{
    internal class Author : Book
    {
        public string Name { get; set; }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
