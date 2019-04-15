using System;
using System.Collections.Generic;
using System.Text;

namespace LearnWithVIP.DataStructure.Sorting
{
    public class SelectionSort
    {
        /// <summary>
        /// Selection sort is conceptually the most simplest sorting algorithm.
        /// This algorithm will first find the smallest element in the array and swap it with the element in the first position,
        /// then it will find the second smallest element and swap it with the element in the second position,
        /// and it will keep on doing this until the entire array is sorted.
        /// It is called selection sort because it repeatedly selects the next-smallest element and swaps it into the right place.
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            var n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (var i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                var min = i;
                for (var j = i + 1; j < n; j++)
                    if (arr[j] < arr[min])
                        min = j;

                // Swap the found minimum element with the first element 
                var temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }
    }

    /*
     *
     *  Time Complexity: O(n2) as there are two nested loops.

        Auxiliary Space: O(1)

        The good thing about selection sort is it never makes more than O(n) swaps
        and can be useful when memory write is a costly operation.
     */
}
