using System;

namespace Searching
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

