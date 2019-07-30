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
            const int count = 4;

            Accauntant[] workers = new Accauntant[count];

            workers[0] = new Accauntant(EnumPost.Trainee, 20);
            workers[1] = new Accauntant(EnumPost.Junior, 45);
            workers[2] = new Accauntant(EnumPost.Middle, 50);
            workers[3] = new Accauntant(EnumPost.Senior, 55);

            bool hasPremium = false;
            foreach (Accauntant worker in workers)
            {
                if (hasPremium = Accauntant.AskForBonus(worker.Post, worker.Hours))
                {
                    Console.WriteLine("{0} - worked {1} hours, and will take a premium",
                                worker.Post, worker.Hours);
                }
                else
                {
                    Console.WriteLine("{0} - worked {1} hours, and will not take a premium",
                                worker.Post, worker.Hours);
                }
            }
            //3
            DateTime nowTime = DateTime.Now;
            Console.WriteLine("Now time is " + nowTime.ToShortDateString());

            DateTime myBirthday = new DateTime(1992, 6, 28);
            Console.WriteLine("My bithday is " + myBirthday.ToShortDateString());

            DateTime myBirthdayNext = new DateTime(nowTime.Year + 1, 6, 28);
                    
            double days = -(nowTime - myBirthdayNext).TotalDays;
            Console.WriteLine("For next birthday {0} days!", (int)days);
           
            Console.ReadLine();
        }
    }
}
