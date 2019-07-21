using System;
using System.Collections.Generic;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*
            Console.Write("Enter number document: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("Document format\n" +
                          "XML - X\n" +
                          "TXT - T\n" +
                          "DOC - D\n");

            List<AbstractHandler> documents = new List<AbstractHandler>();

            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter formant for {0} document: ", i + 1);
                string format = Console.ReadLine();

                if (format == "X")
                {
                    documents.Add(new XMLHandler());
                }
                else if (format == "T")
                {
                    documents.Add(new TXTHandler());
                }
                else if (format == "D")
                {
                    documents.Add(new DOCHandler());
                }
            }

            foreach(AbstractHandler doc in documents)
            { 
                doc.Open();
                doc.Create();
                doc.Change();
                doc.Save();
                Console.WriteLine();
            }
            //2
            Player player = new Player();

            player.Play();
            IPlayable player1 = player as IPlayable;
            player1.Pause();
            player1.Stop();

            Console.WriteLine();

            player.Record();
            IRecodable player2 = player as IRecodable;
            player2.Pause();
            player2.Stop();

            Console.WriteLine();
            */
            //3
            Title title = new Title
            {
                Text = "Good Book"
            };

            Author author = new Author
            {
                Text = "Saska"
            };

            Content content = new Content
            {
                Text = "Very long time ago!"
            };

            List<BookPart> book = new List<BookPart>
            {
                title,
                author,
                content
            };

            foreach (BookPart boo in book)
            {
                boo.Show();
            }

            Console.ReadLine();
        }
    }
}
