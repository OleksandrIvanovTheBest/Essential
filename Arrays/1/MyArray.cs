using System;

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

        public void MaxArray()
        {
            int max = this[0];
            for (int i = 1; i < this.Size; ++i)
            {
                if (max < this[i])
                    max = this[i];
            }
            Console.WriteLine("Max in array {0:G}", max);
        }

        public void MinArray()
        {
            int min = this[0];
            for (int i = 1; i < this.Size; ++i)
            {
                if (min > this[i])
                    min = this[i];
            }
            Console.WriteLine("Min in array {0:G}", min);
        }

        public void SumArray()
        {
            int sum = 0;
            for (int i = 0; i < this.Size; ++i)
            {
                sum += this[i];
            }
            Console.WriteLine("Sum of array elements {0:G}", sum);
        }

        public void AverageArray()
        {
            int average = 0;
            for (int i = 0; i < this.Size; ++i)
            {
                average += this[i];
            }
            average = average / this.Size;
            Console.WriteLine("Average of array elements {0:G}", average);
        }

        public void OddArray()
        {
            Console.WriteLine("Odd numbers from array:");
            for (int i = 0; i < this.Size; ++i)
            {
                if (this[i] % 2 != 0)
                    Console.Write("{0:G} ", this[i]);
            }
            Console.WriteLine();
        }
    }
}
