using System;

namespace LearnWithVIP.DataStructure.Searching
{
    public class BinarySearch
    {
        public static int RecursiveBinarySearch(int[] arr, int beg, int end, int item)
        {
            if (end >= beg)
            {
                int mid = (beg + end) / 2;

                if (arr[mid] == item)
                    return mid;
                else if (arr[mid] < item)
                    return RecursiveBinarySearch(arr, mid + 1, end, item);
                else
                    return RecursiveBinarySearch(arr, beg, mid - 1, item);
            }
            return -1;
        }

        public static int IterativeBinarySearch(int[] arr, int item)
        {
            var beg = 0;
            var end = arr.Length - 1;

            while (beg <= end)
            {
                int mid = (beg + end) / 2;

                if (arr[mid] == item)
                    return mid;

                if (arr[mid] < item)
                    beg = mid + 1;
                else
                    end = mid - 1;
            }
            return -1;
        }
    }
}

/*
 *  SN	Performance	                    Complexity
    1	Worst case	                    O(log n)
    2	Best case	                    O(1)
    3	Average Case	                O(log n)
    4	Worst case space complexity	    O(1)
 */
