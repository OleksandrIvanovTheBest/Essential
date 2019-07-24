using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Enter N array size: ");
            int N = Int32.Parse(Console.ReadLine());

            MyArray array = new MyArray(N);

            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(10);
            }

            array.Show();

            Console.WriteLine("Max     - {0:G}", array.Max);
            Console.WriteLine("Min     - {0:G}", array.Min);
            Console.WriteLine("Sum     - {0:G}", array.Sum);
            Console.WriteLine("Average - {0:G}", array.Average);

            array.OddElements.ForEach((element) => { Console.Write("{0} ", element); });

            Console.WriteLine();
            //2
       
            Console.Write("Enter M matrix size(MxM): ");
            int M = Int32.Parse(Console.ReadLine());

            MyMatrix matrix = new MyMatrix(M, M);   

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i,j] = rand.Next(10);
                }
            }

            matrix.Show();

            Console.WriteLine();

            matrix.MatrixOrder();
            //3
            int count = 5;
            Store store = new Store(count);

            store[0] = new Article("pen", "ATB", 10.2);
            store[1] = new Article("pencil", "Silpo", 12.5);
            store[2] = new Article("book", "Ashan", 20);
            store[3] = new Article("box", "Metro", 50);
            store[4] = new Article("notebook", "Novus", 30.5);

            Console.WriteLine(store[2]);
            Console.WriteLine(store[3]);

            Console.WriteLine(store["pencil"]);
            Console.WriteLine(store["house"]);
            Console.WriteLine(store["table"]);

            Console.WriteLine();
            //4
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["солнце"]);
            Console.WriteLine(dictionary["sun"]);
            Console.WriteLine(dictionary["table"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadLine();
        }
    }
}
