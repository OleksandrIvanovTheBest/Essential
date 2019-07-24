using System;
using System.Collections.Generic;

namespace Arrays
{
    internal class MyArray : IMethods
    {
        private readonly int[] _array = null;

        public int this[int index]
        {
            get    
            {
                return _array[index];
            }
            set   
            {
                _array[index] = value;
            }
        }

        public int Size
        {
            get
            {
                return _array.Length;
            }
        }

        public int Max
        {
            get
            {
                int max = this[0];
                for (int i = 1; i < this.Size; ++i)
                {
                    if (max < this[i])
                        max = this[i];
                }
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = this[0];
                for (int i = 1; i < this.Size; ++i)
                {
                    if (min > this[i])
                        min = this[i];
                }
                return min;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                Array.ForEach(_array, (element) => { sum += element; });
                return sum;
            }
        }

        public int Average
        {
            get
            {
                return Sum / Size;
            }
        }

        public List<int> OddElements
        {
            get
            {
                List<int> list = new List<int>();
                Array.ForEach(_array, (element) =>
                {
                    if (element % 2 != 0)
                    {
                        list.Add(element);
                    }
                });
                return list;
            }
        }

        public MyArray(int size)
        {
            _array = new int[size];
        }

        public void Show()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write("{0:G} ", _array[i]);
            }
            Console.WriteLine();
        }
    }
}
