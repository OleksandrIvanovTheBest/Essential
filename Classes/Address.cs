using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //4(additional task)
    class Address
    {
        private int index, house, apartment;
        private string country, city, street;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public int House
        {
            get { return house; }
            set { house = value; }
        }

        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public void ShowAdress()
        {
            Console.WriteLine("Country   - {0}", country);
            Console.WriteLine("City      - {0}", city);
            Console.WriteLine("Street    - {0}", street);
            Console.WriteLine("House     - {0}", house);
            Console.WriteLine("Apartment - {0}", apartment);
            Console.WriteLine("Index     - {0}", index);
        }
    }
}
