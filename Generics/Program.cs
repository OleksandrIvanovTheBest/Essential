using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
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

            Show(myList1);

            MyList<int> myList2 = new MyList<int>(new int[] { 1, 3, 4, 9 });
            Show(myList2);

            myList2.AddRange(new int[] { 8, 8, 8, 8 });
            Show(myList2);

            Console.WriteLine();
            //2
            Dictionary<int, string> dict = new Dictionary<int, string>();

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "книга");
            myDictionary.Add(3, "солнце");
            myDictionary.Add(4, "яблоко");
            myDictionary.Add(2, "ручка");
            myDictionary.Add(5, "стол");

            Console.WriteLine(myDictionary.Count);

            Console.WriteLine(myDictionary["книга"]);
            Console.WriteLine(myDictionary["дом"]);
            Console.WriteLine(myDictionary["ручка"]);
            Console.WriteLine(myDictionary["стол"]);
            Console.WriteLine(myDictionary["карандаш"]);
            Console.WriteLine(myDictionary["яблуко"]);
            Console.WriteLine(myDictionary["солнце"]);
            Console.WriteLine(myDictionary["sun"]);
            Console.WriteLine(myDictionary["table"]);

            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(myDictionary[i]);
            }

            Console.WriteLine();
            //3
            Array.ForEach(myList2.GetArray(), Console.Write);

            Console.WriteLine();
            //4
            var aInt = MyClass<int>.FactoryMethod();
            aInt = 10;

            if (aInt.GetType() == typeof(int))
            {
                Console.WriteLine(aInt);
            }

            var bDouble = MyClass<double>.FactoryMethod();
            bDouble = 13.894;

            if (bDouble.GetType() == typeof(double))
            {
                Console.WriteLine(bDouble);
            }
        }

        private static void Show(IEnumerable collection)
        {
            foreach (int item in collection)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
