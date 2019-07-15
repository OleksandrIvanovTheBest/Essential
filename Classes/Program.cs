using System;

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
            Title title = new Title();
            title.TitleProperty = tit;

            Console.WriteLine("Enter author name:");
            string aut = Console.ReadLine();
            Author author = new Author();
            author.AuthorProperty = aut;

            Console.WriteLine("Enter content:");
            string con = Console.ReadLine();
            Content content = new Content();
            content.ContentProperty = con;

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

            Point[] points = new Point[number];

            for (int i = 0; i < number; ++i)
            {
                Console.Write("Enter {0:#} point name: ", i + 1);
                string nameP = Console.ReadLine();

                Console.Write("Enter X coordinate: ");
                int height = Int32.Parse(Console.ReadLine());

                Console.Write("Enter Y coordinate: ");
                int width = Int32.Parse(Console.ReadLine());

                points[i] = new Point(height, width, nameP);
            }

            Figure figure;

            if (number == 3)
            {
                figure = new Figure("triangle", points[0], points[1], points[2]);
                figure.CalculatePerimeter();
                figure.Show();
            }
            else if (number == 4)
            {
                figure = new Figure("rectangle", points[0], points[1], points[2], points[3]);
                figure.CalculatePerimeter();
                figure.Show();
            }
            else if (number == 5)
            {
                figure = new Figure("pentagon", points[0], points[1], points[2], points[3], points[4]);
                figure.CalculatePerimeter();
                figure.Show();
            }

            Console.WriteLine();
            //4(additional task)
            Address address = new Address();
            address.Country = "Ukraine";
            address.City = "Shostka";
            address.Street = "Good";
            address.House = 12;
            address.Apartment = 102;
            address.Index = 41100;

            address.ShowAdress();

            Console.ReadLine();
        }
    }
}
