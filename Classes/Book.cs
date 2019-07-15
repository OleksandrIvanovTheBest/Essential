using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //2
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }
    }
}
