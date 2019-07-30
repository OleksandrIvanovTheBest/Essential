using System;

namespace Structures
{
    internal struct Train
    {
        public string Destination { get; set; }

        public int Number { get; set; }

        public DateTime Time { get; set; }

        public void Show()
        {
            Console.WriteLine("Destination - {0}", Destination);
            Console.WriteLine("Train number - {0:G}", Number);
            Console.WriteLine(Time);
        }
    }
}
