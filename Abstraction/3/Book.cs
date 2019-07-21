
namespace Abstraction
{
    internal class Book : IShowable
    {
        private readonly Title _title;
        private readonly Author _author;
        private readonly Content _content;

        public Book(Title title, Author author, Content content)
        {
            this._title = title;
            this._author = author;
            this._content = content;
        }

        public void Show()
        {
            this._title.Show();
            this._author.Show();
            this._content.Show();
        }
    }
}
