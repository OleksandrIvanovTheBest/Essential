using System;

namespace Structures
{
    internal struct Train
    {
        private readonly string _destination;
        public readonly int number;
        private readonly DateTime _time;
        
        public Train(string destination, int number, DateTime time)
        {
            _destination = destination;
            this.number = number;
            _time = time;
        }

        public void Show()
        {
            Console.WriteLine("Destination - {0}", _destination);
            Console.WriteLine("Train number - {0:G}", number);
            Console.WriteLine(_time.ToShortDateString());
        }
    }
}
