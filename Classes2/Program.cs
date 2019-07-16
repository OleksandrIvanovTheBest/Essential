using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Enter currency rates for convert to uah");
            Console.WriteLine("(Fractional number is entered with \",\")");
            Console.Write("usd(~26,08) - ");
            double usd = double.Parse(Console.ReadLine());
            Console.Write("eur(~29,4) - ");
            double eur = double.Parse(Console.ReadLine());
            Console.Write("rub(~0,42) - ");
            double rub = double.Parse(Console.ReadLine());

            Converter convert = new Converter(usd, eur, rub);

            Console.Write("Enter the amount of money in uah to convert: ");
            double uah = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:#.###} uah = {1:#.###} usd", uah, convert.UahToUsd(uah));
            Console.WriteLine("{0:#.###} uah = {1:#.###} eur", uah, convert.UahToEur(uah));
            Console.WriteLine("{0:#.###} uah = {1:#.###} rub", uah, convert.UahToRub(uah));
            Console.WriteLine();

            Console.WriteLine("What currency do you want to convert to uah");
            Console.WriteLine("Enter for convertation\n" +
                              "Dollar - usd\n" +
                              "Euro   - eur\n" +
                              "Ruble  - rub");
            string currency = Console.ReadLine();
            Console.Write("Enter money");
            Console.WriteLine("(Fractional number is entered with \",\")");
            double money = double.Parse(Console.ReadLine());

            Console.Write("{0:#.###} {1} = ", money, currency);

            if (currency == "usd")
            {
                Console.WriteLine("{0:#.###} uah", convert.UsdToUah(money));
            }
            else if (currency == "eur")
            {
                Console.WriteLine("{0:#.###} uah", convert.EurToUah(money));
            }
            else if (currency == "rub")
            {
                Console.WriteLine("{0:#.###} uah", convert.RubToUah(money));
            }
            Console.WriteLine();
            //2
            string name = "Sasha";
            string surname = "Zhele";

            Employee worker = new Employee(name, surname)
            {
                Position = "programmer",
                Experience = 3.5,
                TaxCharge = 0.05
            };

            double salaryPerMonth = 500;

            worker.CalculationSalary(salaryPerMonth);

            worker.Show();
            Console.WriteLine();
            //3
            Invoice invoice = new Invoice(1025, "Ihor", "Telekom")
            {
                Article = "ABC",
                Quantity = 20
            };

            double cost = 500;

            invoice.Show();
            Console.WriteLine("Sum with VAT = {0:#.###}", invoice.CalculeteWithVAT(cost));
            Console.WriteLine("Sum not  VAT = {0:#.###}", invoice.CalculeteNotVAT(cost));
            Console.WriteLine();

            //4(additional task)
            User user = new User("axe", "Alex", "Axis", 30, "16.07.2019");
            user.Show();

            Console.ReadLine();
        }
    }
}
