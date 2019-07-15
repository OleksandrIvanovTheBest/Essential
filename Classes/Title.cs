using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //2
    internal class Title
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
