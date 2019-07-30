using System;

namespace Structures2
{
    internal class Accauntant
    {
        private readonly EnumPost _post;
        private readonly int _hours;

        public EnumPost Post
        {
            get
            {
                return _post;
            }        
        }

        public int Hours
        {
            get
            {
                return _hours;
            }
        }

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
