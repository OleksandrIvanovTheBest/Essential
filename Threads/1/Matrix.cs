using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    internal class Matrix
    {
        const int size = 8;
        private int X = Console.WindowWidth;
        private int Y = Console.WindowHeight;

        private int testY = 0;
        private int testHeight = 6;

        private char[] testMas = new char[6];

        public Matrix()
        {
            for (int i = 0; i < testMas.Length; i++)
            {
                testMas[i] = GetRandomChar();
            }
            //0 - White
            //1 - Green
            //else DarkGreen
        }

        public void Test()
        {
            //for (int i = 0; i < testHeight; i++)
            //{
                //дилнна строки
                for (int j = 0; j < testMas.Length; j++)
                {
                    GetCharColor(j);
                    Console.SetCursorPosition(0, testY + j);
                    Console.Write(GetRandomChar());
                    Thread.Sleep(300);
                }
            //}
        }

        private static void GetCharColor(int color)
        {
            if (color = )
                Console.ForegroundColor = ConsoleColor.White;
            else if (c2 == c1 - 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        private static char GetRandomChar()
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }

        /*
        static object block = new object();

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

        public void MessageMoveM()
        {
            lock (block)
            {
                int height = GetHeight();

                for (int i = 0; i < Console.WindowHeight - height - 3; i++)
                {
                    MessageCreate(height);
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.SetCursorPosition(0, i + 1);//??
                }
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
        */
    }
}
