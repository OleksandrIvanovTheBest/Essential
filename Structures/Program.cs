using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //size 3 for easy checking if entered from the console
            const int count = 3;

            Train[] trains = new Train[count];

            int year, month, day;

            Console.WriteLine("Enter data about trains");
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter destination: ");
                string dest = Console.ReadLine();

                Console.Write("Enter train number: ");
                int numb = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter date time: ");
                Console.Write("year - ");
                year = int.Parse(Console.ReadLine());
                Console.Write("month - ");
                month = int.Parse(Console.ReadLine());
                Console.Write("day - ");
                day = int.Parse(Console.ReadLine());

                trains[i] = new Train(dest, numb, new DateTime(year, month, day));
            }

            Console.WriteLine();

            Console.Write("Enter train number: ");
            int number = int.Parse(Console.ReadLine());

            bool hasFoundValue = false;
            foreach (Train train in trains)
            {
                if (number == train.number)
                {
                    train.Show();
                    hasFoundValue = true;
                }
            }
            if (!hasFoundValue)
                Console.WriteLine("Train does not exist");

            Console.WriteLine();
            //2
            MyClass myClass = new MyClass
            {
                change = "not changed"
            };

            MyStruct myStruct = new MyStruct
            {
                change = "not changed"
            };

            Console.WriteLine("MyClass");

            Console.WriteLine(myClass.change);//not changed
            ClassTaker(myClass);
            Console.WriteLine(myClass.change);//changed

            Console.WriteLine("MyStruct");

            Console.WriteLine(myStruct.change);//not changed
            StructTaker(myStruct);
            Console.WriteLine(myStruct.change);//not changed

            Console.WriteLine();
            //3
            NoteBook noteBook = new NoteBook("Z200", "HP", 20000);

            noteBook.Show();
            
            Console.ReadLine();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
    }
}
