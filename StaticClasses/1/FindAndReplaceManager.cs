using System;

namespace StaticClasses
{
    internal static class FindAndReplaceManager
    {
        public static void FindNext(this string str, Book book)
        {
            if (book.Text.Contains(str))
            {
                Console.WriteLine("\"{0}\" the word is present in the book", str);
            }
            else
            {
                Console.WriteLine("\"{0}\" the word is not present in the book", str);
            }
        }
    }
}
