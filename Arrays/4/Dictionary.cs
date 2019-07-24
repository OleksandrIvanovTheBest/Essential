namespace Arrays
{
    class Dictionary
    {
        private readonly string[] _key = new string[5];
        private readonly string[] _keyUkr = new string[5];
        private readonly string[] _value = new string[5];

        public Dictionary()
        {
            _key[0] = "книга";  _keyUkr[0] = "книга";  _value[0] = "book";
            _key[1] = "ручка";  _keyUkr[1] = "ручка";  _value[1] = "pen";
            _key[2] = "солнце"; _keyUkr[2] = "сонце";  _value[2] = "sun";
            _key[3] = "яблоко"; _keyUkr[3] = "яблуко"; _value[3] = "apple";
            _key[4] = "стол";   _keyUkr[4] = "стiл";   _value[4] = "table";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < _key.Length; i++)
                {
                    if (_key[i] == index)
                        return _key[i] + " - " + _value[i];
                    else if (_keyUkr[i] == index)
                        return _keyUkr[i] + " - " + _value[i];
                    else if (_value[i] == index)
                        return _value[i] + " - " + _key[i] + " - " + _keyUkr[i];
                }
                return string.Format("{0} - no translation for this word.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _key.Length)
                    return _key[index] + " - " +_keyUkr[index] + " - " + _value[index];
                else
                    return "Attempt to access outside the array.";
            }
        }
    }
}
