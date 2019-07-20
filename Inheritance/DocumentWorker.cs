using System;

namespace Inheritance
{
    //3
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing available in Pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving the document is available in the Pro version.");
        }
    }
}
