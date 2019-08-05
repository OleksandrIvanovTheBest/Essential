using System;

namespace Generics2
{
    internal class MyArrayList
    {
        private object[] _objects = null;

        public int Count
        {
            get
            {
                return _objects.Length;
            }
        }

        public object this[int index]
        {
            get
            {
                if (index < Count)
                {
                    return _objects[index];
                }
                throw new ArgumentOutOfRangeException("index parameter is out of range.");
            }
        }

        public MyArrayList()
        {
            _objects = new object[0];
        }

        public void Add(object item)
        {
            IncreaseArrayLength();
            _objects[Count - 1] = item;
        }

        private void IncreaseArrayLength(int item = 1)
        {
            Array.Resize(ref _objects, Count + item);
        }

        public void Show()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, _objects[i]);
            }
        }
    }
}
