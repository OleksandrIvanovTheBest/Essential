using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //1
    internal class Pupil
    {
        public virtual void Study()
        {
            Console.Write("Student's ability to learn - ");
        }

        public virtual void Read()
        {
            Console.Write("Student's ability to read - ");
        }

        public virtual void Write()
        {
            Console.Write("Student's ability to write - ");
        }

        public virtual void Relax()
        {
            Console.Write("Student's ability to rest - ");
        }
    }
}
