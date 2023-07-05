using System;
using System.ComponentModel.Design;

// ReSharper disable InconsistentNaming
namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[]? array)
        {
            if (array != null)
            {
                int i, j, temp;
                for (i = 1; i < array.Length; i++)
                {
                    temp = array[i];
                    for (j = i - 1; j >= 0; j--)
                    {
                        if (array[j] < temp)
                        {
                            break;
                        }

                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(array));
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[]? array)
        {
            InsertionSort(array);
        }
    }
}
