using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Car : Vehicle
    {
        //2
        public Car(int x, int y, int year, double price, double speed)
            : base(x, y, year, price, speed)
        {
        }
    }
}
