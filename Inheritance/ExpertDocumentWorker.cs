using System;

namespace Inheritance
{
    //3
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in new format");
        }
    }
}
