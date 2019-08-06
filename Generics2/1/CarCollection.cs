using System;

namespace Generics2
{
    internal class CarCollection<T> where T : Car
    {
        private T[] _cars = null;

        public int Count
        {
            get
            {
                return _cars.Length;
            }
        }

        public string this[int key]
        {
            get
            {
                if (ContainsKey(key))
                    return _cars[GetIndexKey(key)].name;
                else
                    return string.Format("{0} - no car this year in collection", key);
            }
        }

        public CarCollection()
        {
            _cars = new T[0];
        }

        private bool ContainsKey(int key)
        {
            return GetIndexKey(key) == -1 ? false : true;
        }

        private int GetIndexKey(int key)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_cars[i].year == key)
                    return i;
            }
            return -1;
        }

        public void Add(T car)
        {
            IncreaseArrayLength();
            _cars[Count - 1] = car;
        }

        private void IncreaseArrayLength(int item = 1)
        {
            Array.Resize(ref _cars, Count + item);
        }

        public void Show()
        {
            foreach (T value in _cars)
            {
                Console.WriteLine(value.year + " - " + value.name);
            }
        }

        public void RemoveCollection()
        {
            if (Count > 0)
                _cars = new T[0];
        }
    }
}
