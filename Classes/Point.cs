using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //3
    internal class Point
    {
        private int x, y;
        private string namePoint;

        public int xPoint
        {
            get { return x; }
        }

        public int yPoint
        {
            get { return y; }
        }

        public string NamePoint
        {
            get { return namePoint; }
        }

        public Point(int x, int y, string namePoint)
        {
            this.x = x;
            this.y = y;
            this.namePoint = namePoint;
        }
    }
}
