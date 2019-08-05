using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            CarCollection<Dictionary<int, string>> carCollection = new CarCollection<Dictionary<int, string>>();
            carCollection.Add(1992, "Honda");
            carCollection.Add(2001, "Subaru");
            carCollection.Add(2015, "Pego");

            Console.WriteLine(carCollection[2001]);

            Console.WriteLine(carCollection.Count);

            carCollection.Show();

            carCollection.Remove();

            Console.WriteLine(carCollection[2001]);

            Console.WriteLine();
            //2
            MyDictionary<int, string> countries = new MyDictionary<int, string>();

            countries.Add(1, "Russia");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");

            Console.WriteLine(countries[3]);

            Console.WriteLine(countries.Count);

            countries.Show();

            Console.WriteLine();
            //3
            MyArrayList myArrayList = new MyArrayList();

            myArrayList.Add(2.3);
            myArrayList.Add(55);
            myArrayList.Add("Hello");

            Console.WriteLine(myArrayList[1]);

            myArrayList.Show();
            //4
            ArrayList arrayList = new ArrayList();
            arrayList.Add(23);
            arrayList.Add(76.5);
            arrayList.Add("Hello Man");
            arrayList.Add("Why?");
            arrayList.Add(236.512);

            Console.WriteLine();
            //using for
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.WriteLine();

            //using foreach
            foreach (object item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //5
            MyList<int> myList = new MyList<int>();
            myList.Add(4);
            myList.Add(1);
            myList.Add(2);
            myList.Add(7);
            myList.Add(9);

            Console.WriteLine(myList.Contains(7));
            Console.WriteLine(myList.Contains(10));

            Console.WriteLine(myList);

            Console.ReadLine();
        }
    }
}
