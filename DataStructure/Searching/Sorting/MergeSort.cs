using System;
using System.Collections.Generic;
using System.Text;

namespace LearnWithVIP.DataStructure.Sorting
{
    public class MergeSort
    {
        /// <summary>
        /// Merge Sort follows the rule of Divide and Conquer to sort a given set of numbers/elements, recursively,
        /// hence consuming less time.
        ///
        /// In Merge Sort, the given unsorted array with n elements, is divided into n subarrays,
        /// each having one element, because a single element is always sorted in itself.
        /// Then, it repeatedly merges these sub arrays, to produce new sorted sub arrays,
        /// and in the end, one complete sorted array is produced.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            Merge_Sort(arr, 0, arr.Length - 1);
        }

        private static void Merge_Sort(int[] arr, int beg, int end)
        {
            if (end > beg)
            {
                // Same as (beg + end)/2, but avoids overflow for large beg and end 
                var mid = beg + (end - beg) / 2;
                Merge_Sort(arr, beg, mid);
                Merge_Sort(arr, (mid + 1), end);
                Merge(arr, beg, mid, end);
            }
        }

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int i, j;

            int n1 = middle - left + 1;  // Number of elements in left array
            int n2 = right - middle;    // Number of elements in right array

            /* create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /* Copy data to temp arrays L[] and R[] */
            // Array.Copy(arr, left, L, 0, n1);
            // Array.Copy(arr, middle + 1, R, 0, n2);

            //      OR

            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
                L[i] = arr[left + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[middle + 1 + j];

            i = 0;      // Initial index of first sub array 
            j = 0;      // Initial index of second sub array 
            var k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                    arr[k++] = L[i++];   // same as arr[k] = L[i]; k++; i++;
                else
                    arr[k++] = R[j++];
            }

            /* Copy the remaining elements of L[], if there are any */
            while (i < n1)
            {
                arr[k++] = L[i++];
            }

            /* Copy the remaining elements of R[], if there are any */
            while (j < n2)
            {
                arr[k++] = R[j++];
            }

        }
    }
}

/*
 * 
 * */
