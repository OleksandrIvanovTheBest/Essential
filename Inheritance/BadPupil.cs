using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //1
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.Write("Bad\n");
        }

        public override void Read()
        {
            base.Read();
            Console.Write("Bad\n");
        }

        public override void Write()
        {
            base.Write();
            Console.Write("Bad\n");
        }

        public override void Relax()
        {
            base.Relax();
            Console.Write("Excelent\n");
        }
    }
}
