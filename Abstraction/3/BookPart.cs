using System;

namespace Abstraction
{
    abstract internal class BookPart : IShowable
    {
        public string Text { get; set; }

        public virtual void Show() 
        {
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
