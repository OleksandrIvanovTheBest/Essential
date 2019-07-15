using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //1
    internal class Rectangle
    {
        private double side1, side2;

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }


        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double CalculateArea()
        {
            return side1 * side2;
        }

        private double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }
    }
}
