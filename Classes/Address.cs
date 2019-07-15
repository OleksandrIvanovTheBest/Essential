using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //4(additional task)
    class Address
    {
        private int _index, _house, _apartment;
        private string _country, _city, _street;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public int House
        {
            get { return _house; }
            set { _house = value; }
        }

        public int Apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public void ShowAdress()
        {
            Console.WriteLine("Country   - {0}", _country);
            Console.WriteLine("City      - {0}", _city);
            Console.WriteLine("Street    - {0}", _street);
            Console.WriteLine("House     - {0}", _house);
            Console.WriteLine("Apartment - {0}", _apartment);
            Console.WriteLine("Index     - {0}", _index);
        }
    }
}
