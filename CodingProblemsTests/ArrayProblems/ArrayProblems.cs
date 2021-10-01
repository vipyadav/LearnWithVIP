using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace LearnWithVIP.CodingProblems.ArrayProblems
{
    public static class ArrayProblems
    {
        public static void FindDuplicateElements()
        {
            //Initialize array   
            int[] arr = new int[] { 1, 2, 3, 4, 2, 7, 3, 8, 8, 3 };

            Debug.WriteLine("Duplicate elements in given array: ");

            //Searches for duplicate element  
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Debug.WriteLine(arr[j] + " ");
                }
            }
        }

        public static void FindDuplicateElementsByLinq()
        {
            //Initialize array   
            int[] arr = new int[] { 1, 2, 3, 4, 2, 7, 3, 8, 8, 3 };

            var duplicateElements = arr.GroupBy(p => p)
                                       .Where(g => g.Count() > 1)
                                       .Select(g => g.Key);

            Debug.WriteLine("Duplicate elements in given array: ");

            Debug.WriteLine(string.Join(" ", duplicateElements));
        }

        // Finding duplicate integers in an array and display how many times they occurred

        public static void FindDuplicateElementsWithOccurrence()
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
                Debug.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
        }

        //Q: Given a sorted array of N integers and an integer K. 
        //     You have to find the top 5 elements from an array which are closest to integer K.

        /*
         * Find k closest elements to a given value
            Difficulty Level : Medium
            Last Updated : 28 Jun, 2019
            Given a sorted array arr[] and a value X, find the k closest elements to X in arr[].
            Examples:

            Input: K = 4, X = 35
                   arr[] = {12, 16, 22, 30, 35, 39, 42, 45, 48, 50, 53, 55, 56}
            Output: 30 39 42 45
            Note that if the element is present in array, then it should not be in output, only the other closest elements are required.
         */


        /* Function to find the cross over point 
		(the point before which elements are 
		smaller than or equal to x and after which 
		greater than x)*/
        static int findCrossOver(int[] arr, int low, int high, int x)
        {
            // Base cases 
            // x is greater than all 
            if (arr[high] <= x)
                return high;

            // x is smaller than all 
            if (arr[low] > x)
                return low;

            // Find the middle point 
            /* low + (high - low)/2 */
            int mid = (low + high) / 2;

            /* If x is same as middle element, then return mid */
            if (arr[mid] <= x && arr[mid + 1] > x)
                return mid;

            /* If x is greater than arr[mid], then either arr[mid + 1] is ceiling of x or 
			ceiling lies in arr[mid+1...high] */
            if (arr[mid] < x)
                return findCrossOver(arr, mid + 1,high, x);

            return findCrossOver(arr, low, mid - 1, x);
        }

        // This function prints k closest elements 
        // to x in arr[]. n is the number of 
        // elements in arr[] 
        public static void PrintKclosest(int[] arr, int x, int elementsCounts, int arrLen)
        {
            // Find the crossover point 
            int l = findCrossOver(arr, 0, arrLen - 1, x);

            // Right index to search 
            int r = l + 1;

            // To keep track of count of elements 
            int count = 0;

            // If x is present in arr[], then reduce 
            // left index Assumption: all elements in 
            // arr[] are distinct 
            if (arr[l] == x) l--;

            // Compare elements on left and right of 
            // crossover point to find the k closest 
            // elements 
            while (l >= 0 && r < arrLen && count < elementsCounts)
            {
                if (x - arr[l] < arr[r] - x)
                    Debug.Write(arr[l--] + " ");
                else
                    Debug.Write(arr[r++] + " ");
                count++;
            }

            // If there are no more elements on right 
            // side, then print left elements 
            while (count < elementsCounts && l >= 0)
            {
                Debug.Write(arr[l--] + " ");
                count++;
            }

            // If there are no more elements on left 
            // side, then print right elements 
            while (count < elementsCounts && r < arrLen)
            {
                Debug.Write(arr[r++] + " ");
                count++;
            }
        }
    }
}
