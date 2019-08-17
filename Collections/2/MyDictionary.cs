using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private KeyValuePair<TKey, TValue>[] _keyValuePairs = null;

        public int Count
        {
            get
            {
                return _keyValuePairs.Length;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                if (ContainsKey(key))
                {
                    return _keyValuePairs[GetIndexKey(key)].Value;
                }
                throw new ArgumentOutOfRangeException("index parameter is out of range.");
            }
        }

        public MyDictionary()
        {
            _keyValuePairs = new KeyValuePair<TKey, TValue>[0];
        }

        public MyDictionary(int size)
        {
            _keyValuePairs = new KeyValuePair<TKey, TValue>[size];
        }

        private bool ContainsKey(TKey key)
        {
            return GetIndexKey(key) == -1 ? false : true;
        }

        private int GetIndexKey(TKey key)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Equals(_keyValuePairs[i].Key, key))
                    return i;
            }
            return -1;
        }

        public void Add(TKey key, TValue value)
        {
            IncreaseArrayLength();
            _keyValuePairs[Count - 1] = new KeyValuePair<TKey, TValue>(key, value);
        }

        private void IncreaseArrayLength(int item = 1)
        {
            Array.Resize(ref _keyValuePairs, Count + item);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<TKey, TValue>>)_keyValuePairs).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

        //Or use yield
        /*
        int position = -1;

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            while (true)
            {
                if (position < Count - 1)
                {
                    position++;
                    yield return _keyValuePairs[position];
                }
                else
                {
                    Reset();
                    yield break;  // Выход из цикла.       
                }
            }
        }
        */
    }
}
