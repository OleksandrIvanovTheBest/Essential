using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal static class Arrays
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            IEnumerator ie = list.GetEnumerator();

            int size = 0;

            while (ie.MoveNext())
                size++;

            ie.Reset();

            T[] array = new T[size];

            for (int i = 0; i < size && ie.MoveNext(); i++)
            {
                array[i] = (T)ie.Current;
            }

            ie.Reset();

            return array;
        }
    }
}
