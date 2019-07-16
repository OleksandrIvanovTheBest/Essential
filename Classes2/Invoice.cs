using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    //3
    class Invoice
    {
        private readonly int _account;
        private readonly string _customer, _provider;
        private string _article;
        int _quantity;
        private const double vat = 0.2;

        public string Article
        {
            private get { return _article; }
            set { _article = value; }
        }

        public int Quantity
        {
            private get { return _quantity; }
            set { _quantity = value; }
        }

        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        public double CalculeteWithVAT(double cost)
        {
            return cost * _quantity + cost * _quantity * vat;
        }
        public double CalculeteNotVAT(double cost)
        {
            return cost * _quantity - cost * _quantity * vat;
        }   

        public void Show()
        {
            Console.WriteLine("Account  - {0}", _account);
            Console.WriteLine("Customer - {0}", _customer);
            Console.WriteLine("Provider - {0}", _provider);
            Console.WriteLine("Article  - {0}", _article);
            Console.WriteLine("Quantity - {0}", _quantity);
        }
    }
}
