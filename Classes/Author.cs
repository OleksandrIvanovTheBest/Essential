using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //2
    internal class Author
    {
        private string str_author;

        public string AuthorProperty
        {
            get
            {
                return str_author;
            }
            set
            {
                str_author = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(str_author);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
