using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    //2
    internal class Employee
    {
        private readonly string _name, _surname;
        private const double _salary = 300;
      
        public string Position { get; set; }

        public double Experience { get; set; }

        public double TaxCharge { get; set; }
        
        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public double CalculateSalary()
        {
            return Experience * (_salary * TaxCharge);
        }

        public void Show()
        {
            Console.WriteLine("Name       - {0}", _name);
            Console.WriteLine("Surname    - {0}", _surname);
            Console.WriteLine("Position   - {0}", Position);
            Console.WriteLine("Experience - {0:#.###}", Experience);
            Console.WriteLine("Tax_charge - {0:#.###}", TaxCharge);
            Console.WriteLine("Slary      - {0:#.###}", CalculateSalary());
        }
    }
}
