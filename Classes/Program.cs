using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Enter sides of a rectangle:");
            double sid1 = Double.Parse(Console.ReadLine());
            double sid2 = Double.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(sid1, sid2);

            Console.WriteLine("Area = {0} Perimeter = {1}", rect.Area, rect.Perimeter);
            Console.WriteLine();
            //2
            Console.WriteLine("Enter book title:");
            string tit = Console.ReadLine();
            Title title = new Title
            {
                Name = tit
            };

            Console.WriteLine("Enter author name:");
            string aut = Console.ReadLine();
            Author author = new Author
            {
                Name = aut
            };

            Console.WriteLine("Enter content:");
            string con = Console.ReadLine();
            Content content = new Content
            {
                Text = con
            };

            Book book = new Book(title, author, content);
            book.Show();

            Console.WriteLine();
            //3
            Console.WriteLine("Enter the number of points for the polygon\n" +
                              "3 - triangle\n" +
                              "4 - rectangle\n" +
                              "5 - pentagon");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter points name better A, B, C, D or E");

            List<Point> points = new List<Point>();

            for (int i = 0; i < number; ++i)
            {
                Console.Write("Enter {0:#} point name: ", i + 1);
                string nameP = Console.ReadLine();

                Console.Write("Enter X coordinate: ");
                int x = Int32.Parse(Console.ReadLine());

                Console.Write("Enter Y coordinate: ");
                int y = Int32.Parse(Console.ReadLine());

                points.Add(new Point(x, y, nameP));
            }

            Figure figure;

            if (number == 3)
            {
                figure = new Figure(points[0], points[1], points[2]);
            }
            else if (number == 4)
            {
                figure = new Figure(points[0], points[1], points[2], points[3]);
            }
            else if (number == 5)
            {
                figure = new Figure(points[0], points[1], points[2], points[3], points[4]);
            }
            else
            {
                figure = new Figure();
            } 
            figure.CalculatePerimeter();
            figure.Show();

            Console.WriteLine();
            //4(additional task)
            Address address = new Address
            {
                Country = "Ukraine",
                City = "Shostka",
                Street = "Good",
                House = 12,
                Apartment = 102,
                Index = 41100
            };

            address.ShowAdress();

            Console.ReadLine();
        }
    }
}
