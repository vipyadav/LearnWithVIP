using System;
using System.Collections.Generic;
using System.Text;

namespace LearnWithVIP.DataStructure.Sorting
{
    public class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            var n = arr.Length;
            for (var i = 0; i < n - 1; i++)
                for (var j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        /// <summary>
        /// To optimize bubble sort algorithm, we can introduce a flag to monitor whether elements are getting swapped inside the inner for loop.
        /// Hence, in the inner for loop, we check whether swapping of elements is taking place or not, everytime.
        /// If for a particular iteration, no swapping took place, it means the array has been sorted and we can jump out of the for loop, instead of executing all the iterations.
        /// </summary>
        public static void OptimizedSort(int[] arr)
        {
            var n = arr.Length;
            var isSwapped = false;

            for (var i = 0; i < n - 1; i++)
            {
                for (var j = 0; j < n - i - 1; j++)
                {
                    isSwapped = false;
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        isSwapped = true;
                    }
                }

                // if value of flag is false after all the iterations of inner loop
                // then break out
                if (!isSwapped)
                {
                    break;
                }

            }
        }

    }

    /*
     * average and worst case complexity are of Ο(n2) 
     * */


    /*
     *  Worst and Average Case Time Complexity: O(n*n). Worst case occurs when array is reverse sorted.

        Best Case Time Complexity: O(n). Best case occurs when array is already sorted.

        Auxiliary Space: O(1)

        Boundary Cases: Bubble sort takes minimum time (Order of n) when elements are already sorted.
     *
     *
     */
}
