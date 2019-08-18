namespace Operators
{
    internal struct Point
    {
        private readonly int _x, _y, _z;

        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1._x + p2._x, p1._y + p2._y, p1._z + p2._z);
        }

        public override string ToString()
        {
            return string.Format("x - {0}, y - {1}, z - {2}", _x, _y, _z);
        }
    }
}
