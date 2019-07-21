using System;

namespace Abstraction
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT open");
        }
        public override void Create()
        {
            Console.WriteLine("TXT created");
        }
        public override void Change()
        {
            Console.WriteLine("TXT changed");
        }
        public override void Save()
        {
            Console.WriteLine("TXT saved");
        }
    }
}
