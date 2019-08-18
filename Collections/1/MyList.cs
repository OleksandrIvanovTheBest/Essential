using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class MyList<T> : IEnumerable<T>
    {
        private T[] values = null;

        public int Count
        {
            get
            {
                return values.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                return values[index];
            }
        }

        public MyList()
        {
            values = new T[0];
        }

        public MyList(IEnumerable<T> collection) : this()
        {
            InitializeCollection(collection);
        }

        public void Add(T item)
        {
            IncreaseArrayLength();
            values[Count - 1] = item;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            InitializeCollection(collection);
        }

        private void IncreaseArrayLength(int item = 1)
        {
            Array.Resize(ref values, Count + item);
        }

        private void InitializeCollection(IEnumerable<T> collection)
        {
            IEnumerator ie = collection.GetEnumerator();

            int oldCount = Count;
            IncreaseArrayLength(GetCount(collection));

            for (int i = oldCount; i < Count && ie.MoveNext(); i++)
            {
                values[i] = (T)ie.Current;
            }

            ie.Reset();
        }

        private int GetCount(IEnumerable<T> collection)
        {
            int size = 0;

            IEnumerator<T> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
                size++;

            enumerator.Reset();

            return size;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
