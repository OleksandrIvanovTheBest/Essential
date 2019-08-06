namespace Generics2
{
    internal abstract class Car
    {
        public readonly int year;
        public readonly string name;

        public Car(int year, string name)
        {
            this.year = year;
            this.name = name;
        }
    }
}
