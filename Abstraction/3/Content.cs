using System;

namespace Abstraction
{
    internal class Content : BookPart
    {  
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Show();
        }
    }
}
