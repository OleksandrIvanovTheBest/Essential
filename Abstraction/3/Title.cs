using System;

namespace Abstraction
{
    internal class Title : Book
    {
        public string Name { get; set; }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
