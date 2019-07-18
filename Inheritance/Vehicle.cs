using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //2
    internal class Vehicle
    {
        private readonly int _x, _y, _year;
        private readonly double _price, _speed;

        public Vehicle() { }

        public Vehicle(int x, int y, int year, double price, double speed)
        {
            _x = x;
            _y = y;
            _year = year;
            _price = price;
            _speed = speed;
        }

        public virtual void Show()
        {
            Console.WriteLine("x     - {0:#}", _x);
            Console.WriteLine("y     - {0:#}", _y);
            Console.WriteLine("year  - {0:#}", _year);
            Console.WriteLine("price - {0:#.##}", _price);
            Console.WriteLine("speed - {0:#.##}", _speed);
        }
    }
}
