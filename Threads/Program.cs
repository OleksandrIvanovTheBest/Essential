using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 and 2
            var matrix = new Matrix();

            foreach (var t in matrix.StartMatrix())
            {
                t.Start();
            }

            Console.ReadLine();
        
            //need comment task "1 and 2" to run task 3
            //3
            //Task task = new Task(() => PrintNumbersByDescending(6));
            //task.Start();

            //Console.ReadLine();
        }

        static void PrintNumbersByDescending(int x)
        {
            if (x == 0)
            {
                Console.WriteLine("thread {0} - number {1}", Task.CurrentId, x);
            }
            else
            {
                Console.WriteLine("thread {0} - number {1}", Task.CurrentId, x);
                new Task(() => Thread.Sleep(500));
                new Task(() => { PrintNumbersByDescending(x - 1); }).Start();      
            }
        }
    }
}
