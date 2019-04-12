using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions
{
    public static class ArrayExtensions
    {
        public static float AverageExtensions(this Array arr)
        {
            int[] a = arr.Cast<int>().ToArray();
            return (float)a.Sum() / arr.Length;
        }
        /// <summary>
        /// Determines if int array is sorted from 0 -> Max via Recursion
        /// </summary>
        public static bool IsSortedWithRecursion(int[] ar, int length)
        {
            if (length == 0)
                return true;
            return ar[length - 1] <= ar[length] && IsSortedWithRecursion(ar, length - 1);
        }

        /// <summary>
        /// Determines if int array is sorted from 0 -> Max
        /// </summary>
        public static bool IsSorted(this int[] arr)
        {
            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Determines if string array is sorted from A -> Z
        /// </summary>
        public static bool IsSorted(this string[] arr)
        {
            for (var i = 1; i < arr.Length; i++)
            {
                if (string.Compare(arr[i - 1], arr[i], StringComparison.Ordinal) > 0) // If previous is bigger, return false
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Determines if int array is sorted from Max -> 0
        /// </summary>
        public static bool IsSortedDescending(this int[] arr)
        {
            for (var i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Determines if string array is sorted from Z -> A
        /// </summary>
        public static bool IsSortedDescending(this string[] arr)
        {
            for (var i = arr.Length - 2; i >= 0; i--)
            {
                if (string.Compare(arr[i], arr[i + 1], StringComparison.Ordinal) < 0) // If previous is smaller, return false
                {
                    return false;
                }
            }
            return true;
        }

    }
}
