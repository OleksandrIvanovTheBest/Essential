using System;
using System.Linq;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            const int count = 5;

            Worker[] workers = new Worker[count];

            workers[0] = new Worker("Antonov", "AA", "trainee", 2014);
            workers[1] = new Worker("Vadimov", "DD", "junior", 2003);
            workers[2] = new Worker("Ivanchenko", "TT", "middle", 1998);
            workers[3] = new Worker("Abrasyan", "AB", "senior", 1995);
            workers[4] = new Worker("Zuravko", "VD", "essential", 2001);

            workers = workers.OrderBy(x => x.surname).ToArray();

            foreach (Worker worker in workers)
            {
                worker.Show();
            }

            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your initials");
            string initials = Console.ReadLine();

            Console.WriteLine("Enter your position");
            string position = Console.ReadLine();

            Console.WriteLine("Enter year of employment");
            string year = Console.ReadLine();

            if (int.TryParse(year, out int y))
            {
                Worker worker1 = new Worker(surname, initials, position, y);
                worker1.Show();
            }
            else
            {
                Console.WriteLine("Invalid input! Year ust be between 1992 and 2019");
            }
            //2       
            Price[] products =
            {
                new Price("Shauma", "Silpo", 56.8),
                new Price("Ariel", "EKO", 83.7),
                new Price("Gala", "ATB", 25.8),
                new Price("Tide", "Novus", 50)
            };

            products = products.OrderBy(x => x.magazine).ToArray();

            foreach (Price product in products)
            {
                product.Show();
            }

            string productName = "Mulo";

            try
            {
                bool hasFoundValue = false;
                foreach (Price product in products)
                {
                    if (productName == product.name)
                    {
                        product.Show();
                        hasFoundValue = true;
                    }
                }
                if (!hasFoundValue)
                    throw new MyException("Product does not exist!"); ;
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            //3
            Console.WriteLine("First number");
            string first = Console.ReadLine();

            if (Double.TryParse(first, out double a))
            {
                Console.WriteLine("You entered the valid double {0}", a);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine("Second number");
            string second = Console.ReadLine();

            if (Double.TryParse(second, out double b))
            {
                Console.WriteLine("You entered the valid double {0}", b);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine("Enter arithmetic sign: \"+\", \"-\", \"*\", \":\"");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine("Sum - {0:G}", a.Add(b));
                    break;
                case "-":
                    Console.WriteLine("Sub - {0:G}", a.Sub(b));
                    break;
                case "*":
                    Console.WriteLine("Multiple - {0:G}", a.Mul(b));
                    break;
                case ":":
                    Console.WriteLine("Division - {0:G}", a.Div(b));
                    break;
                default:
                    Console.WriteLine("Invalid sign");
                    break;
            }

            Console.ReadLine();
        }
    }
}