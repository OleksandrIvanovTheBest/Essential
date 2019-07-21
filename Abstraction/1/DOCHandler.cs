using System;

namespace Abstraction
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC open");
        }
        public override void Create()
        {
            Console.WriteLine("DOC created");
        }
        public override void Change()
        {
            Console.WriteLine("DOC changed");
        }
        public override void Save()
        {
            Console.WriteLine("DOC saved");
        }
    }
}
