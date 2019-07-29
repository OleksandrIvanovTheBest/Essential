using System;

namespace StaticClasses
{
    internal class Book
    {
        public string Text { get; }

        public Book(string text)
        {
            Text = text;
        }

        //2
        public class Notes
        {
            public static string _notes;

            public static void BookNotes(string str)
            {
                _notes = str;
            }

            public static void ShowNotes()
            {
                Console.WriteLine("Notes : " + _notes);
            }
        }
    }
}
