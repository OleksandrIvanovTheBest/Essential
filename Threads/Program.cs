using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //1
            Console.CursorVisible = false;

            Random rand = new Random();            

            //ParameterizedThreadStart

            var matrix = new Matrix();

            matrix.StartMatrix();

            //Matrix.MessageColumnMove(0, 6);
           
            //Console.WriteLine("BufferWidth : " + Console.BufferWidth);//80
            //Console.WriteLine("BufferHeight: " + Console.BufferHeight);//300
            //Console.WriteLine("WindowWidth : " + Console.WindowWidth);//80
            //Console.WriteLine("WindowHeight: " + Console.WindowHeight);//25
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
    }
}
