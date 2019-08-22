using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static readonly object locker = new object();

        static void ViewMessage(object height)
        {
            for (int i = 0; i < (int)height; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(GetRandomChar());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(GetRandomChar());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(GetRandomChar());

            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            //1
            //ThreadStart matrixCode = new ThreadStart(MatrixCode);
            //Thread thread = new Thread(MatrixCode);
            //thread.Start();

            //MatrixCode();

            //for (int i = 0; i < 10; i++)
            //{
            //    MatrixCode();
            //    Thread.Sleep(400);
            //    //Console.Clear();
            //}

            //Console.SetWindowSize(80, 25);

            int height = GetHeight();

            ParameterizedThreadStart viewMessage = new ParameterizedThreadStart(ViewMessage);
            Thread thread = new Thread(viewMessage);
            thread.Start(height);


            for (int i = 0; i < Console.WindowHeight - 8; i++)
            {
                ViewMessage(height);
                Thread.Sleep(500);
                Console.Clear();
                Console.SetCursorPosition(0, i + 1);
                //Console.WriteLine();
            }

            //Console.SetCursorPosition(0, i);

            //int origRow = Console.CursorTop;
            //int origCol = Console.CursorLeft;


            //Console.WriteLine("BufferWidth : " + Console.BufferWidth);//80
            //Console.WriteLine("BufferHeight: " + Console.BufferHeight);//300
            //Console.WriteLine("WindowWidth : " + Console.WindowWidth);//80
            //Console.WriteLine("WindowHeight: " + Console.WindowHeight);//25



            //for (int i = 0; i < 20; i++)
            //{
            //    lock (locker)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Primary");
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //        Thread.Sleep(100);
            //    }
            //}

            //2
            //3
            Console.ReadLine();
        }

        private static char GetRandomChar()
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }

        private static int GetHeight()
        {
            Random rand = new Random();
            return rand.Next(15);
        }
    }
}
