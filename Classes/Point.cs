using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //3
    internal class Point
    {
        private readonly int _x, _y;
        private readonly string _name;

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public string Name
        {
            get { return _name; }
        }

        public Point(int x, int y, string namePoint)
        {
            this._x = x;
            this._y = y;
            this._name = namePoint;
        }
    }
}
