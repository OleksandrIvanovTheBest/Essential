using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //1
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.Write("Excelent\n");
        }

        public override void Read()
        {
            base.Read();
            Console.Write("Excelent\n");
        }

        public override void Write()
        {
            base.Write();
            Console.Write("Excelent\n");
        }

        public override void Relax()
        {
            base.Relax();
            Console.Write("Bad\n");
        }
    }
}
