using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    //2
    internal class Employee
    {
        private readonly string _name, _surname;
        private string _position;
        private double _experience, _tax_charge, _salary;

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public double Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        public double TaxCharge
        {
            get { return _tax_charge; }
            set { _tax_charge = value; }
        }

        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public void CalculationSalary(double salary)
        {
            _salary = _experience * (salary * _tax_charge);
        }

        public void Show()
        {
            Console.WriteLine("Name       - {0}", _name);
            Console.WriteLine("Surname    - {0}", _surname);
            Console.WriteLine("Position   - {0}", _position);
            Console.WriteLine("Experience - {0:#.###}", _experience);
            Console.WriteLine("Tax_charge - {0:#.###}", _tax_charge);
            Console.WriteLine("Slary      - {0:#.###}", _salary);
        }
    }
}
