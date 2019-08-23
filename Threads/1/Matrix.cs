using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    internal class Matrix
    {
        object block = new object();

        private void MessageCreate(int height)
        {
            for (int i = 0; i < height; i++)
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

        public void MessageMove()
        {
            lock (block)
            {
                int height = GetHeight();

                //for (int i = 0; i < Console.WindowHeight - height - 3; i++)
                //{
                    MessageCreate(height);
                    Thread.Sleep(500);
                    //Console.Clear();
                    //Console.SetCursorPosition(0, i + 1);//??
                //}
            }
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
