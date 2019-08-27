using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 and 2
            var matrix = new Matrix();

            matrix.StartMatrix();

            while (true)
            {
            }
            //need comment task "1 and 2" to run task 3
            //3
            //PrintNumbersByDescending(6);
        }

        static void PrintNumbersByDescending(int x)
        {
            int hash = Thread.CurrentThread.GetHashCode();

            if (x == 0)
            {
                Console.WriteLine("thread {0} - number {1}", hash, x);
            }
            else
            {
                Console.WriteLine("thread {0} - number {1}", hash, x);
                Thread.Sleep(500);
                new Thread(() => { PrintNumbersByDescending(x-1); }).Start();
            }
        }
    }
}
