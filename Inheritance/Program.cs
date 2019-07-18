using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //keyboard input interface
            Console.Write("Enter the number of pupils(from 2 to 4) - ");
            int number = Int32.Parse(Console.ReadLine());

            List<Pupil> pupils = new List<Pupil>();

            Console.Write("Enter student profile\n" +
                          "Excelent - E\n" +
                          "Good     - G\n" +
                          "Bad      - B\n");

            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter for {0} pupil: ", i+1);
                string prof = Console.ReadLine();

                if (prof == "E")
                {
                    pupils.Add(new ExcelentPupil());
                }
                else if (prof == "G")
                {
                    pupils.Add(new GoodPupil());
                }
                else if (prof == "B")
                {
                    pupils.Add(new BadPupil());
                }
            }

            ClassRoom classRoom;

            if (number == 2)
            {
                classRoom = new ClassRoom(pupils[0], pupils[1]);
            }
            else if (number == 3)
            {
                classRoom = new ClassRoom(pupils[0], pupils[1], pupils[2]);
            }
            else if (number == 4)
            {
                classRoom = new ClassRoom(pupils[0], pupils[1], pupils[2], pupils[3]);
            }
            else
            {
                classRoom = new ClassRoom();
            }

            classRoom.Show();
            //2
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Plane(100, 200, 1992, 1000, 500, 9000, 300));
            vehicles.Add(new Car(50, 100, 1980, 800, 150));
            vehicles.Add(new Ship(300, 100, 2014, 5000, 100, "NewEngland", 500));

            foreach(Vehicle v in vehicles)
            {
                v.Show();
                Console.WriteLine();
            }
            //3
            Console.Write("Enter key(pro or exp): ");
            string key = Console.ReadLine();

            DocumentWorker documentWorker;

            if (key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            else
            {
                documentWorker = new DocumentWorker();
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();

            Console.WriteLine();
            //4(additional task)
            RedColor printerRed = new RedColor();
            printerRed.Print("Hello!");

            Printer printer = printerRed as Printer;
            printer.Print("Hello!");

            RedColor printerRed2 = printer as RedColor;
            printerRed2.Print("Hello!");
          
            Console.ReadLine();
        }
    }
}
