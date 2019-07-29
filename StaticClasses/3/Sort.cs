namespace StaticClasses
{
    internal static class Sort
    {
        //Selection sort, O(n^2)
        public static void SortAscending(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[index] > array[j])
                        index = j;
                }
                
                Swap<int>(ref array[index], ref array[i]);
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
