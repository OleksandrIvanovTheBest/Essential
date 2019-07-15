using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //2
    internal class Title
    {
        private string str_title;

        public string TitleProperty
        {
            get
            {
                return str_title;
            }
            set
            {
                str_title = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str_title);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
