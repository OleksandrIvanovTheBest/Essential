using System;
using System.Text;

namespace Generics
{
    internal class MyDictionary<TKey, TValue>
    {
        private readonly string[] _rusWords = null;
        private readonly string[] _engWords = new string [5];

        public int Count
        {
            get
            {
                return _rusWords.Length;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                    return _rusWords[index] + " - " + " - " + _engWords[index];
                else
                    return "Attempt to access outside the array.";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                {
                    if (_rusWords[i] == index)
                        return _rusWords[i] + " - " + _engWords[i];
                    else if (_engWords[i] == index)
                        return _engWords[i] + " - " + _rusWords[i];
                }
                return string.Format("{0} - no translation for this word.", index);
            }
        }

        public MyDictionary()
        {
            _rusWords = new string[_engWords.Length];

            _engWords[0] = "book";
            _engWords[1] = "pen";
            _engWords[2] = "sun";
            _engWords[3] = "apple";
            _engWords[4] = "table";

            Array.ForEach(_engWords, EncodeString);
        }

        public void Add(int index, string item)
        {
            _rusWords[index - 1] = item;
        }
 
        private void EncodeString(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            str = Encoding.UTF8.GetString(bytes);
        }
    }
}
