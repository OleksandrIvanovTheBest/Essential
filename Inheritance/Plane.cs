using System;

namespace Inheritance
{
    //2
    internal class Plane : Vehicle
    {
        private readonly double _height;
        private readonly int _passengers;

        public Plane(int x, int y, int year, double price, double speed, double height, int passengers)
               : base(x, y, year, price, speed)
        {
            _height = height;
            _passengers = passengers;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("height - {0:#.##}", _height);
            Console.WriteLine("passengers - {0:#}", _passengers);
        }
    }
}
