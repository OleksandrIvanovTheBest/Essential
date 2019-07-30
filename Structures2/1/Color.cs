using System;

namespace Structures2
{
    internal static class Color
    {
        public static void Print(string stroka, int color)
        {
            if (color == (int)EnumColor.Red)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (color == (int)EnumColor.Green)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (color == (int)EnumColor.Blue)
                Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
