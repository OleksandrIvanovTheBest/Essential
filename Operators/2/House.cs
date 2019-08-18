using System;

namespace Operators
{
    internal class House : ICloneable
    {
        public int width, height;

        public House(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public House ShallowCopy()
        {
            return (House)MemberwiseClone();
        }

        public House DeepCopy()
        {
            House other = (House)this.MemberwiseClone();
            other.width = width;
            other.height = height;
            return other;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        //return new House(width, height) as object;
        public override string ToString()
        {
            return "Width: " + width + " Height: " + height;
        }
    }
}
