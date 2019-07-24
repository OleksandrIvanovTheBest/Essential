namespace Arrays
{
    class Store
    {
        private readonly Article[] _article = null;

        public Store(int count)
        {
            _article = new Article[count];
        }

        public Article this[int index]
        {
            set
            {
                _article[index] = value;
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < _article.Length; i++)
                {
                    if (index == _article[i].Name)
                    {
                        return string.Format("{0}, {1}, {2:G}",
                         _article[i].Name, _article[i].Store, _article[i].Price);
                    }
                }
                return string.Format("{0} no product in store", index);
            }
        }

        //public string this[int index]
        //{
        //    get
        //    {
        //        if (index >= 0 && index < _article.Length)
        //            return string.Format("{0}, {1}, {2:G}",
        //             _article[index].Name, _article[index].Store, _article[index].Price);
        //        else
        //            return "Attempt to access outside the array.";
        //    }
        //}
    }
}
