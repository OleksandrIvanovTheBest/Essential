using System;
using System.Collections.Generic;
using System.Text;

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
