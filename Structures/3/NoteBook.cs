using System;

namespace Structures
{
    internal struct NoteBook
    {
        public string Model { get; }

        public string Manufacturer { get; }

        public double Price { get; }

        public NoteBook(string model, string manufacturer, double price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine("Model        - {0}", Model);
            Console.WriteLine("Manufacturer - {0}", Manufacturer);
            Console.WriteLine("Price        - {0:#.###}", Price);
        }
    }
}
