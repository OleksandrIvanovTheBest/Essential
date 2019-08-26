using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    internal class Matrix
    {
        const int size = 8;
        private static int consoleWidth = Console.WindowWidth;
        private static int consoleHeight = Console.WindowHeight;



        static object lockObject = new object();

        private char[] testMas = new char[6];

        public Matrix()
        {
           
        }

        public void StartMatrix()
        {
            for (int i = 0; i < consoleWidth; i++)
            {
                new Thread(() => MessageColumnMove(i, GetMessageHeight())).Start();
                Thread.Sleep(1000);
            }
        }

        private static void MessageColumnMove(int columnNumber, int messageHeight)
        {
            for (int i = 0; i < consoleHeight - messageHeight; i++)
            {
                PrintMessage(messageHeight, columnNumber, i, GetRandomChar);

                Thread.Sleep(500);

                PrintMessage(messageHeight, columnNumber, i, () => ' ');
            }
        }

        private static void PrintMessage(int messageHeight, int columnNumber, int rowNumber, Func<char> getChar)
        {
            for (int j = 0; j < messageHeight; j++)
            {
                lock (lockObject)
                {
                    Console.SetCursorPosition(columnNumber, rowNumber + j);
                    Console.Write(getChar());
                }
            }
        }

        private static void GetCharColor(int color)
        {
            //if (color = )
            //    Console.ForegroundColor = ConsoleColor.White;
            //else if (c2 == c1 - 1)
            //    Console.ForegroundColor = ConsoleColor.Green;
            //else
            //    Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        private static int GetRandomColumn()
        {

        }

        private static char GetRandomChar()
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }

        private static int GetMessageHeight()
        {
            Random rand = new Random();
            return rand.Next(15);
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
