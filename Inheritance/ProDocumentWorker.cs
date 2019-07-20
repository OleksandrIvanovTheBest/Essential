using System;

namespace Inheritance
{
    //3
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format,\nsaving in other formats is available in the Expert version");
        }
    }
}
