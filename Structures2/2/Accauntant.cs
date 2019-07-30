using System;

namespace Structures2
{
    internal class Accauntant
    {
        public readonly EnumPost _post;
        public readonly int _hours;

        public Accauntant(EnumPost post, int hours)
        {
            _post = post;
            _hours = hours;
        }

        public static bool AskForBonus(EnumPost worker, int hours)
        {
            if (hours > (int)worker)
                return true;
            else
                return false;
        }

        public void Show()
        {
            Console.WriteLine("{0} worked {1} hours", Post, Hours);
        }
    }
}
