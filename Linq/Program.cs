using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            var cars = new List<Car>
            {
                new Car
                {
                    Mark = "Audi",
                    Model = "R8",
                    Year = 2018,
                },
                new Car
                {
                    Mark = "BMW",
                    Model = "M5",
                    Year = 2015,
                }
            };

            var customers = new List<Customer>
            {
                new Customer
                {
                    Model = "R8",
                    Name = "Sasha",
                    Phone = 0985556622,
                },
                new Customer
                {
                    Model = "M5",
                    Name = "Aleksandr",
                    Phone = 0936668885,
                },
            };

            var query = from customer in customers
                        join car in cars
                        on customer.Model equals car.Model
                        where customer.Name == "Sasha"
                        select new
                        {
                            Model = customer.Model,
                            Name = customer.Name,
                            Phone = customer.Phone,
                            Mark = car.Mark,
                            Year = car.Year
                        };


            foreach (var item in query)
            {
                Console.WriteLine("Model - {0}, name - {1}, phone - {2}, Mark - {3}, Year - {4}",
                                    item.Model, item.Name, item.Phone, item.Mark, item.Year);
            }

            Console.WriteLine();
            //2
            var dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["солнце"]);
            Console.WriteLine(dictionary["sun"]);
            Console.WriteLine(dictionary["table"]);

            Console.WriteLine(new string('-', 20));

            for (dynamic i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine();
            //3
            dynamic calculator = new Calculator();

            Console.WriteLine(calculator.Add(4, 3));
            Console.WriteLine(calculator.Add("1", 2));
            Console.WriteLine(calculator.Diff(10, 4));

            Console.ReadLine();
        }
    }
}
