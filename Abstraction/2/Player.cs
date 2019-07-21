using System;

namespace Abstraction
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause Play");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop Play");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause Record");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop Record");
        }
    }
}
