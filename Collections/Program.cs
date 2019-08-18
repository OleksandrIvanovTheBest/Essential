using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            MyList<int> myList1 = new MyList<int>();
            Console.WriteLine(myList1.Count);

            myList1.Add(7);
            myList1.Add(9);
            myList1.Add(0);
            myList1.Add(3);

            foreach (int item in myList1)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            MyList<int> myList2 = new MyList<int>(new int[] { 1, 3, 4, 9 });

            foreach (int item in myList2)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            myList2.AddRange(new int[] { 8, 8, 8, 8 });

            foreach (int item in myList2)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine();
            //2
            MyDictionary<int, string> countries = new MyDictionary<int, string>();

            countries.Add(1, "Russia");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");

            foreach (KeyValuePair<int, string> item in countries)
            {
                Console.Write("{0} - {1}", item.Key, item.Value);
                Console.WriteLine();
            }
            Console.WriteLine();
            //3
            MyList<int> myList3 = new MyList<int>(new int[] { 9, 8, 5, 5, 0 });

            Array.ForEach(myList3.GetArray(), Console.Write);

            Console.WriteLine();

            Console.WriteLine();
            //4
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            foreach (int i in GetEvenNumbers(array))
            {
                Console.Write("{0} ", i);
            }

            Console.ReadLine();
        }
        //4
        private static IEnumerable<int> GetEvenNumbers(int[] numbers)
        {
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                    yield return item;
            }
        }
    }
}
