using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics2
{
    internal class MyList<T> : IMyList<T>, IEnumerable<T>
    {
        private T[] _array = null;

        public T this[int index]
        {
            get
            {
                return _array[index];
            }
        }

        public int Count
        {
            get
            {
                return _array.Length;
            }
        }

        public MyList()
        {
            _array = new T[0];
        }

        public MyList(IEnumerable<T> collection) : this()
        {
            InitializeCollection(collection);
        }

        public void Add(T item)
        {
            IncreaseArrayLength();
            _array[Count - 1] = item;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            InitializeCollection(collection);
        }

        private void IncreaseArrayLength(int item = 1)
        {
            Array.Resize(ref _array, Count + item);
        }

        private void InitializeCollection(IEnumerable<T> collection)
        {
            IEnumerator ie = collection.GetEnumerator();

            int oldCount = Count;
            IncreaseArrayLength(GetCount(collection));

            for (int i = oldCount; i < Count && ie.MoveNext(); i++)
            {
                _array[i] = (T)ie.Current;
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
            return ((IEnumerable<T>)_array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Clear()
        {
            if (Count > 0)
                _array = new T[0];
        }

        public bool Contains(T item)
        {
            foreach (T element in _array)
            {
                if (Equals(element, item))
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format(ArrayToString());
        }

        private string ArrayToString()
        {
            string words = null;

            foreach (T element in _array)
            {
                words += element.ToString() + " ";
            }

            return words;
        }
    }
}
