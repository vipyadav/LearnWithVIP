using System;
using System.Collections.Generic;
using System.Text;

namespace LearnWithVIP.DataStructure.Sorting
{
    public class InsertionSort
    {
        /// <summary>
        /// Insertion sort is a simple sorting algorithm that works the way we sort playing cards in our hands.
        ///
        /// Loop over positions in the array, starting with index 1.
        /// Each new position is like the new card handed to you by the dealer,
        /// and you need to insert it into the correct place in the sorted subarray to the left of that position.
        /// </summary>
        /// <param name="arr"> Array of Ints</param>
        public static void Sort(int[] arr)
        {
            for (var i = 1; i < arr.Length; ++i)
            {
                var key = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

        }
    }
}
