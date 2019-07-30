using System;

namespace Structures2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Color.Print("Hello!", 0);
            Color.Print("Hello!", 1);
            Color.Print("Hello!", 5);
            Color.Print("Hello!", 2);
            //2
            
            Accauntant[] workers =
            {
                new Accauntant(EnumPost.Trainee, 20),
                new Accauntant(EnumPost.Junior, 45),
                new Accauntant(EnumPost.Middle, 50),
                new Accauntant(EnumPost.Senior, 55)
            };

            foreach (Accauntant worker in workers)
            {
                if (Accauntant.AskForBonus(worker.post, worker.hours))
                {
                    Console.WriteLine("{0} - worked {1} hours, and will take a premium",
                                worker.post, worker.hours);
                }
                else
                {
                    Console.WriteLine("{0} - worked {1} hours, and will not take a premium",
                                worker.post, worker.hours);
                }
            }
            //3
            Console.WriteLine("Now time is " + DateTime.Now.ToShortDateString());

            DateTime myBirthday = new DateTime(1992, 6, 28);
            Console.WriteLine("My bithday is " + myBirthday.ToShortDateString());

            DateTime myBirthdayNext = new DateTime(DateTime.Now.Year + 1, 6, 28);
                    
            double days = (myBirthdayNext - DateTime.Now).TotalDays;
            Console.WriteLine("For next birthday {0} days!", (int)days);
          
            Console.ReadLine();
        }
    }
}
