namespace Arrays
{
    class Store
    {
        private readonly Article[] _articles = null;

        public Store(int count)
        {
            _articles = new Article[count];
        }

        public Article this[int index]
        {
            get
            {
                return _articles[index];
            }
            set
            {
                _articles[index] = value;
            }
        }

        public string this[string index]
        {
            get
            {
                foreach(Article article in _articles)
                {
                    if (index == article.Name)
                    {
                        return article.ToString();
                    }
                }
                return string.Format("{0} no product in store", index);
            }
        }
    }
}
