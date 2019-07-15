using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //3
    internal class Figure
    {
        private List<Point> _points = new List<Point>();

        public Figure() { }

        public Figure(Point point1, Point point2, Point point3)
        {
            _points.AddRange(new[] { point1, point2, point3 });
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            _points.AddRange(new[] { point1, point2, point3, point4 });
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _points.AddRange(new[] { point1, point2, point3, point4, point5 });
        }

        public double CalculateLengthSide(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((Convert.ToDouble(point2.X - point1.X)), 2)
                           + Math.Pow((Convert.ToDouble(point2.Y - point1.Y)), 2));
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < _points.Count; i++)
            {
                if (i == _points.Count - 1)
                {
                    perimeter += CalculateLengthSide(_points[i], _points[0]);
                }
                else
                {
                    perimeter += CalculateLengthSide(_points[i], _points[i + 1]);
                }    
            }
            return perimeter;
        }

        public void Show()
        {
            Console.WriteLine(ConcatenatePoints());
        }

        private string ConcatenatePoints()
        {
            string result = "Polygon name ";
            foreach (Point point in _points)
            {
                result += point.Name;
            }

            result += "\nPerimeter = " + CalculatePerimeter().ToString("#.###");
            return result;
        }
    }
}
