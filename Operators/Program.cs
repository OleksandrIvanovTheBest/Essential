using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Block block1 = new Block(4, 5, 6, 8);
            Block block2 = new Block(4, 5, 6, 8);
            Block block3 = new Block(5, 7, 4, 7);

            Console.WriteLine(block1);
            Console.WriteLine(block2);
            Console.WriteLine(block3);

            Console.WriteLine("block1 == block2 = {0}", block1 == block2);
            Console.WriteLine("block1 == block2 = {0}", block1 == block3);

            Console.WriteLine();
            //2   
            House houseOriginal = new House(100, 200);
            House houseClone = houseOriginal.Clone() as House;

            Console.WriteLine("Clone");

            Console.WriteLine(houseOriginal);
            Console.WriteLine(houseClone);

            Console.WriteLine("Change houseClone");
            houseClone.width = 300;

            Console.WriteLine(houseOriginal);
            Console.WriteLine(houseClone);

            House houseShallow = houseOriginal.ShallowCopy();

            Console.WriteLine("ShallowCopy");
            Console.WriteLine(houseOriginal);
            Console.WriteLine(houseShallow);

            Console.WriteLine("Change houseOriginal");
            houseOriginal.height = 500;
            houseOriginal.width = 500;

            Console.WriteLine(houseOriginal);
            Console.WriteLine(houseShallow);

            House houseDeep = houseOriginal.DeepCopy();

            Console.WriteLine("DeepCopy");
            Console.WriteLine(houseOriginal);
            Console.WriteLine(houseDeep);

            houseOriginal.height = 1000;
            houseOriginal.width = 1000;

            Console.WriteLine("Change houseOriginal");

            Console.WriteLine(houseOriginal);
            Console.WriteLine(houseDeep);

            Console.WriteLine();
            //3
            Date date1 = new Date(2000, 3, 5);
            Date date2 = new Date(2004, 7, 24);

            Console.WriteLine(date2 - date1);

            Console.WriteLine(date2 + 1100);

            Console.WriteLine();
            //4
            Point A = new Point(1, 1, 3);
            Point B = new Point(2, 2, 5);

            Console.WriteLine(A + B);

            Console.ReadLine();
        }
    }
}
