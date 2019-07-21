using System;

namespace Abstraction
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML open");
        }
        public override void Create()
        {
            Console.WriteLine("XML created");
        }
        public override void Change()
        {
            Console.WriteLine("XML changed");
        }
        public override void Save()
        {
            Console.WriteLine("XML saved");
        }
    }
}
