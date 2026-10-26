using System;

namespace DSA.Lab01
{
    public static class SortAlgorithms
    {
        public static void InsertionSort(int[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            for (int i = 1; i < values.Length; i++)
            {
                // 1. Store the value you want to insert.
                int valuenow = values[i];
                int n = i - 1;

                // 2. Shift larger values one position to the right.
                while (n >= 0 && values[n] > valuenow)
                {
                    values[n + 1] = values[n];
                    n--;
                }
                // 3. Put the stored value into the gap.
                values[n + 1] = valuenow;
            }
        }
    }
}
