using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    internal class MyList<T>
    {
        //readonly not needed if you need to implement insert and delete
        private T[] _value = null;

        public int Count
        {
            get
            {
                return _value.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                return _value[index];
            }
        }

        public MyList()
        {
            _value = new T[0];
        }

        public MyList(IEnumerable<T> collection) : this()
        {
            InitializeCollection(collection);
        }

        public void Add(T item)
        {
            PlusItems(1);
            _value[Count - 1] = item;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            InitializeCollection(collection);
        }
       
        public void Show()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0} ", _value[i]);
            }
            Console.WriteLine();
        }

        private void PlusItems(int item)
        {
            Array.Resize(ref _value, Count + item);
        }

        private void InitializeCollection(IEnumerable<T> collection)
        {
            //IEnumerator<T> ie = collection.GetEnumerator();
            IEnumerator ie = collection.GetEnumerator();
            int size = 0;
            //the length of the collection
            while (ie.MoveNext())
                size++;

            ie.Reset();

            int oldCount = Count;
            PlusItems(size);

            for (int i = oldCount; i < Count && ie.MoveNext(); i++)
            {
                _value[i] = (T)ie.Current;
            }
            ie.Reset();
        }
    }
}
