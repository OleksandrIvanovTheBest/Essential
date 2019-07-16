using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    //4
    internal class User
    {
        private readonly string _login, _first_name, _last_name, _date;
        private readonly int _age;  

        public User(string login, string first_name, string last_name, int age, string date)
        {
            _login = login;
            _first_name = first_name;
            _last_name = last_name;
            _date = date;
            _age = age;
        }

        public void Show()
        {
            Console.WriteLine("Login      - {0}", _login);
            Console.WriteLine("First name - {0}", _first_name);
            Console.WriteLine("Last name  - {0}", _last_name);
            Console.WriteLine("Age        - {0}", _age);
            Console.WriteLine("Date       - {0}", _date);
        }
    }
}
