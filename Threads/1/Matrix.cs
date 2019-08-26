using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    internal class Matrix
    {
        const string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

        private static int consoleWidth = Console.WindowWidth;
        private static int consoleHeight = Console.WindowHeight;
        private static object lockObject = new object();

        private static Random rand = new Random();

        public Matrix()
        {
            Console.CursorVisible = false;
            ThreadPool.SetMaxThreads(10, 4);
        }

        public void StartMatrix()
        {
            var shuffeledColumnNumbers = GetShuffeledColumnNumbers(consoleWidth);

            foreach (var columnNumber in shuffeledColumnNumbers)
            {
                ThreadPool.QueueUserWorkItem((object state) => MessageColumnMove(columnNumber, GetMessageHeight()));
                Thread.Sleep(500);
                ThreadPool.QueueUserWorkItem((object state) => MessageColumnMove(columnNumber, GetMessageHeight()));
            }
        }

        private List<int> GetShuffeledColumnNumbers(int consoleWidth)
        {
            var shuffeledColumnNumbers = new List<int>();
            var valuesQuantity = 0;

            while (valuesQuantity < consoleWidth)
            {
                var currValue = rand.Next(consoleWidth);

                if (!shuffeledColumnNumbers.Contains(currValue))
                {
                    shuffeledColumnNumbers.Add(currValue);
                    valuesQuantity++;
                }

            }

            return shuffeledColumnNumbers;
        }

        private static void MessageColumnMove(int columnNumber, int messageHeight)
        {
            int i = 0;

            while (true)
            {
                PrintMessage(messageHeight, columnNumber, i, GetRandomChar);

                Thread.Sleep(300);

                PrintMessage(messageHeight, columnNumber, i, () => ' ');

                i++;
                if (i == consoleHeight - messageHeight)
                {
                    i = 0;
                }
            }
        }

        private static void PrintMessage(int messageHeight, int columnNumber, int rowNumber, Func<char> getChar)
        {
            for (int j = 0; j < messageHeight; j++)
            {
                lock (lockObject)
                {
                    SetCharColor(j, messageHeight);
                    Console.SetCursorPosition(columnNumber, rowNumber + j);
                    Console.Write(getChar());
                }
            }
        }

        private static void SetCharColor(int charPosition, int lastPosition)
        {
            if (charPosition == lastPosition - 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (charPosition == lastPosition - 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
        }

        private static char GetRandomChar()
        {
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }

        private static int GetMessageHeight()
        {
            return rand.Next(4, 10);
        }
    }
}
