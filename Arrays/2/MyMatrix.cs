using System;

namespace Arrays
{
    internal class MyMatrix
    {
        private readonly int[,] _matrix = null;

        public int this[int index1, int index2]
        {
            get
            {
                return _matrix[index1, index2];
            }
            set
            {
                _matrix[index1, index2] = value;
            }
        }

        public int Row
        {
            get
            {
                //What better?
                return _matrix.GetLength(0);
                //return _matrix.GetUpperBound(0) + 1;
            }
        }

        public int Column
        {
            get
            {
                return _matrix.GetLength(1);
                //return _matrix.GetUpperBound(1) + 1;
            }
        }


        public MyMatrix(int row, int column)
        {
            _matrix = new int[row, column];
        }

        public void Show()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.Write("{0:G} ", _matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void MatrixOrder()
        {
            for (int i = 1; i < Row - 1; i++)
            {
                for (int j = 0; j < Row - i; j++)
                {
                    for (int k = 0; k < Column - i; k++)
                    {
                        Console.Write("{0:G} ", _matrix[j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
