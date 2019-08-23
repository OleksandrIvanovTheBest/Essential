using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        protected static int origRow;
        protected static int origCol;

        delegate void Delegat();

        static object block3 = new object();

        public static void FuncMove()
        {
            lock (block3)
            {
               
                for (int i = 0; i < 8; i++)
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
        }

        static void Main(string[] args)
        {
            //1
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(formatString, i);
            //    Console.WriteLine();
            //    //Console.WriteLine("{0,4}", i);
            //}
            //Console.ReadLine();

            //Matrix matrix = new Matrix();

            //ThreadStart matrix1 = new ThreadStart(matrix.MessageMove);
            //Thread thread1 = new Thread(matrix1);
            //thread1.Start();

            //matrix.MessageMove();

            Delegat delegat = new Delegat(FuncMove);

            int origRow = Console.CursorTop;
            int origCol = Console.CursorLeft;

            WriteAt(delegat, 0, 0);
            WriteAt(delegat, 1, 0);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        //Console.SetCursorPosition(i, 0);
            //        //Console.Write(" ");
            //        //matrix.Method();
            //        //Console.SetCursorPosition(i, j);
            //        WriteAt(delegat, i, j);


            //        //new Thread(matrix.Method).Start();
            //        //Console.SetCursorPosition(i, i);
            //        //Thread.Sleep(5000);
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    new Thread(matrix.MessageMove).Start();
            //}

            //Console.Clear();
            //origRow = Console.CursorTop;
            //origCol = Console.CursorLeft;

            //Thread.Sleep(500);
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

            //ParameterizedThreadStart viewMessage = new ParameterizedThreadStart(ViewMessage);
            //Thread thread = new Thread(viewMessage);
            //thread.Start(height);

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < Console.WindowHeight - 8; j++)
            //    {
            //        ParameterizedThreadStart viewMessage = new ParameterizedThreadStart(ViewMessage);
            //        Thread thread = new Thread(viewMessage);
            //        thread.Start(height);

            //        //ViewMessage(height);
            //        Thread.Sleep(500);
            //        Console.Clear();
            //        Console.SetCursorPosition(i, j + 1);
            //        //Console.WriteLine();
            //    }
            //}

            //Console.SetCursorPosition(0, i);

            //int origRow = Console.CursorTop;
            //int origCol = Console.CursorLeft;

            //Console.WriteLine("BufferWidth : " + Console.BufferWidth);//80
            //Console.WriteLine("BufferHeight: " + Console.BufferHeight);//300
            //Console.WriteLine("WindowWidth : " + Console.WindowWidth);//80
            //Console.WriteLine("WindowHeight: " + Console.WindowHeight);//25
            //2
            //3
            Console.ReadLine();
        }

        private static void WriteAt(Delegat dg, int x, int y)
        {
            Console.SetCursorPosition(origCol + x, origRow + y);
            dg.Invoke();
        }

        private static char GetRandomChar()
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }
    }
}
