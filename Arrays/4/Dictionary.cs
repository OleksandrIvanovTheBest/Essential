using System;
using System.Text;

namespace Arrays
{
    class Dictionary
    {
        private readonly string[] _rusWords = new string[5];
        private readonly string[] _ukrWords = new string[5];
        private readonly string[] _engWords = new string[5];

        public Dictionary()
        {
            _rusWords[0] = "книга";  _ukrWords[0] = "книга";  _engWords[0] = "book";
            _rusWords[1] = "ручка";  _ukrWords[1] = "ручка";  _engWords[1] = "pen";
            _rusWords[2] = "солнце"; _ukrWords[2] = "сонце";  _engWords[2] = "sun";
            _rusWords[3] = "яблоко"; _ukrWords[3] = "яблуко"; _engWords[3] = "apple";
            _rusWords[4] = "стол";   _ukrWords[4] = "стіл";   _engWords[4] = "table";

            Array.ForEach(_rusWords, EncodeString);
            Array.ForEach(_ukrWords, EncodeString);
            Array.ForEach(_engWords, EncodeString);
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < _rusWords.Length; i++)
                {
                    if (_rusWords[i] == index)
                        return _rusWords[i] + " - " + _engWords[i];
                    else if (_ukrWords[i] == index)
                        return _ukrWords[i] + " - " + _engWords[i];
                    else if (_engWords[i] == index)
                        return _engWords[i] + " - " + _rusWords[i] + " - " + _ukrWords[i];
                }
                return string.Format("{0} - no translation for this word.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _rusWords.Length)
                    return _rusWords[index] + " - " +_ukrWords[index] + " - " + _engWords[index];
                else
                    return "Attempt to access outside the array.";
            }
        }

        private void EncodeString(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            str = Encoding.UTF8.GetString(bytes);
        }
    }
}
