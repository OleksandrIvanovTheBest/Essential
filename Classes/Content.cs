using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //2
    internal class Content
    {
        private string str_content;

        public string ContentProperty
        {
            get
            {
                return str_content;
            }
            set
            {
                str_content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str_content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
