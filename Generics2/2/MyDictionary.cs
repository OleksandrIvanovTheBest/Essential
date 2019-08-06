using System;
using System.Collections.Generic;

namespace Generics2
{
    internal class MyDictionary<TKey, TValue> where TKey : struct
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

        public void Show()
        {
            foreach (KeyValuePair<TKey, TValue> keyValuePair in _keyValuePairs)
            {
                Console.WriteLine("Key - {0}\nValue - {1}", keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}
