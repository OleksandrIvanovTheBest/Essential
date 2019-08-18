using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Operators
{
    [Serializable]
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
            using (MemoryStream stream = new MemoryStream())
            { 
                if (!this.GetType().IsSerializable)
                {
                    throw new SerializationException("No serializable atribute!");
                }

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Position = 0;

                return formatter.Deserialize(stream);
            }
        }
        public override string ToString()
        {
            return "Width: " + width + " Height: " + height;
        }
    }
}
