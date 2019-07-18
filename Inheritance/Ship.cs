using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //2
    internal class Ship : Vehicle
    {
        private readonly string _port;
        private readonly int _passengers;

        public Ship(int x, int y, int year, double price, double speed, string port, int passengers)
                  : base(x, y, year, price, speed)
        {
            _port = port;
            _passengers = passengers;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("port  - {0}", _port);
            Console.WriteLine("passengers - {0:#}", _passengers);
        }
    }
}
