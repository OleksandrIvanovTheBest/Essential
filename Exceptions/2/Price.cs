using System;

namespace Exceptions
{
    internal struct Price
    {
        public readonly string name;
        public readonly string magazine;
        public readonly double cost;

        public Price(string name, string magazine, double cost)
        {
            this.name = name;
            this.magazine = magazine;
            this.cost = cost;
        }

        public void Show()
        {
            Console.WriteLine("Name product  - {0}", name);
            Console.WriteLine("Magazie       - {0}", magazine);
            Console.WriteLine("Cost          - {0}", cost);
        }
    }
}
