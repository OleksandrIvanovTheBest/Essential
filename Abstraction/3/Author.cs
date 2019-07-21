using System;

namespace Abstraction
{
    internal class Author : BookPart
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Show();
        }
    }
}
