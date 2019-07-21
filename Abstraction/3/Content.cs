using System;

namespace Abstraction
{
    internal class Content : Book
    {
        public string Text { get; set; }
   
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
