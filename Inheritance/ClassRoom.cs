using System;
using System.Collections.Generic;

namespace Inheritance
{
    //1
    internal class ClassRoom
    {
        private readonly List<Pupil> _pupil = new List<Pupil>();

        public ClassRoom() {}

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            _pupil.AddRange(new[] { pupil1, pupil2 });
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            _pupil.AddRange(new[] { pupil1, pupil2, pupil3});
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            _pupil.AddRange(new[] { pupil1, pupil2, pupil3, pupil4 });
        }

        public void Show()
        {
            foreach(Pupil pupil in _pupil)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
}
