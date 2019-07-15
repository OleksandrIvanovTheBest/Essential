using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //3
    internal class Figure
    {
        private string nameFigure;
        private double perimeter;
        private Point[] point = new Point[3];

        public Figure(string nameFigure, Point point1, Point point2, Point point3)
        {
            this.nameFigure = nameFigure;
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
        }

        public Figure(string nameFigure, Point point1, Point point2, Point point3, Point point4)
        {
            this.nameFigure = nameFigure;
            ResizePlusOnePointArray(ref point);
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
            point[3] = point4;
        }

        public Figure(string nameFigure, Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.nameFigure = nameFigure;
            ResizePlusOnePointArray(ref point);
            ResizePlusOnePointArray(ref point);
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
            point[3] = point4;
            point[4] = point5;
        }

        public double CalculateLengthSide(Point X, Point Y)
        {
            double Length = Math.Sqrt(Math.Pow((Convert.ToDouble(Y.xPoint - X.xPoint)), 2)
                                    + Math.Pow((Convert.ToDouble(Y.yPoint - X.yPoint)), 2));
            return Length;
        }

        private void ResizePlusOnePointArray(ref Point[] arr)
        {
            Array.Resize(ref arr, arr.Length + 1);
        }

        public void CalculatePerimeter()
        {
            perimeter = 0;
            if (nameFigure == "triangle")
            {
                perimeter += CalculateLengthSide(point[0], point[1]) +
                             CalculateLengthSide(point[1], point[2]) +
                             CalculateLengthSide(point[2], point[0]);
            }
            else if (nameFigure == "rectangle")
            {
                perimeter += CalculateLengthSide(point[0], point[1]) +
                             CalculateLengthSide(point[1], point[2]) +
                             CalculateLengthSide(point[2], point[3]) +
                             CalculateLengthSide(point[3], point[0]);
            }
            else if (nameFigure == "pentagon")
            {
                perimeter += CalculateLengthSide(point[0], point[1]) +
                             CalculateLengthSide(point[1], point[2]) +
                             CalculateLengthSide(point[2], point[3]) +
                             CalculateLengthSide(point[3], point[4]) +
                             CalculateLengthSide(point[4], point[0]);
            }
        }

        public void Show()
        {
            if (nameFigure == "triangle")
            {
                Console.WriteLine("Polygon name {0}{1}{2} {3}\nPerimeter = {4:#.###}",
                                   point[0].NamePoint, point[1].NamePoint, point[2].NamePoint,
                                   nameFigure, perimeter);
            }
            if (nameFigure == "rectangle")
            {
                Console.WriteLine("Polygon name {0}{1}{2}{3} {4}\nPerimeter = {5:#.###}",
                                   point[0].NamePoint, point[1].NamePoint, point[2].NamePoint,
                                   point[3].NamePoint, nameFigure, perimeter);
            }
            if (nameFigure == "pentagon")
            {
                Console.WriteLine("Polygon name {0}{1}{2}{3}{4} {5}\nPerimeter = {6:#.###}",
                                   point[0].NamePoint, point[1].NamePoint, point[2].NamePoint,
                                   point[3].NamePoint, point[4].NamePoint, nameFigure, perimeter);
            }

        }
    }
}
