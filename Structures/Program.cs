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
                trains[i].Destination = Console.ReadLine();

                Console.Write("Enter train number: ");
                trains[i].Number = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter date time: ");
                Console.Write("year - ");
                year = int.Parse(Console.ReadLine());
                Console.Write("month - ");
                month = int.Parse(Console.ReadLine());
                Console.Write("day - ");
                day = int.Parse(Console.ReadLine());
                trains[i].Time = new DateTime(year, month, day);
            }

            Console.WriteLine();

            Console.Write("Enter train number: ");
            int number = int.Parse(Console.ReadLine());

            foreach (Train train in trains)
            {
                if (number == train.Number)
                {
                    train.Show();
                }
            }
            //Console.WriteLine("There is no such train");

            Console.WriteLine();
            //2
            MyClass myClass = new MyClass();
            myClass.change = "not changed";

            MyStruct myStruct = new MyStruct();
            myStruct.change = "not changed";

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
