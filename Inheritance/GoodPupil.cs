using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //1
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            base.Study();
            Console.Write("Good\n");
        }

        public override void Read()
        {
            base.Read();
            Console.Write("Good\n");
        }

        public override void Write()
        {
            base.Write();
            Console.Write("Good\n");
        }

        public override void Relax()
        {
            base.Relax();
            Console.Write("Good\n");
        }

    }
}
