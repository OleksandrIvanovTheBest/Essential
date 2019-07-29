using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Book book = new Book("Who is the best player and world ?");

            Console.Write("Please enter word for search: ");
            string find = Console.ReadLine();

            find.FindNext(book);

            Console.WriteLine();
            //2
            Console.Write("Please enter notes for book: ");

            Book.Notes.BookNotes(Console.ReadLine());
            Book.Notes.ShowNotes();

            Console.WriteLine();
            //3
            int[] array = new int[7] { 1, 3, 8, 4, 0, 2, 5 };
            Console.WriteLine("Array before sorting");
            Array.ForEach(array, Console.Write);
            Console.WriteLine();

            array.SortAscending();

            Console.WriteLine("Array after sorting ascending");
            Array.ForEach(array, Console.Write);

            Console.WriteLine("\n");
            //4
            double a = 17;
            double b = 6;

            Console.WriteLine("Sum      - {0:G}", a.CalculateSum(b));
            Console.WriteLine("Diff     - {0:G}", a.CalculateDiff(b));
            Console.WriteLine("Multiple - {0:G}", a.CalculateMultiple(b));
            Console.WriteLine("Division - {0:#.###}", a.CalculateDivision(b));

            Console.ReadLine();
        }
    }
}
