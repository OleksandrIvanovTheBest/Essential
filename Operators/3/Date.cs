using System;

namespace Operators
{
    internal class Date
    {
        public int year, month, day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public Date(DateTime dt)
        {
            year = dt.Year;
            month = dt.Month;
            day = dt.Day;
        }

        public static Date operator -(Date d1, Date d2)
        {
            return new Date(d1.year - d2.year, d1.month - d2.month, d1.day - d2.day);
        }

        public static Date operator +(Date d1, int days)
        {
            DateTime dt = new DateTime(d1.year, d1.month, d1.day);

            dt = dt.AddDays(days);

            return new Date(dt);
        }

        public override string ToString()
        {
            return string.Format("year - {0}, month - {1}, day - {2}", year, month, day);
        }
    }
}
