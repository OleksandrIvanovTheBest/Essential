namespace Arrays
{
    class Article
    {
        private readonly string _name, _store;
        private readonly double _price;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Store
        {
            get
            {
                return _store;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public Article(string name, string store, double price)
        {
            _name = name;
            _store = store;
            _price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2:G}", Name, Store, Price);
        }
    }
}
