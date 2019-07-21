using System;

namespace Abstraction
{
    internal class Title : BookPart
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Show();
        }
    }
}
