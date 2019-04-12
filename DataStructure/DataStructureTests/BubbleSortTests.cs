using System;
using System.Diagnostics;
using Common.Extensions;
using LearnWithVIP.DataStructure.Searching;
using LearnWithVIP.DataStructure.Sorting;
using Xunit;

namespace LearnWithVIP.DataStructureTests
{
    public class BubbleSortTests
    {
        [Fact]
        public void BubbleSort_Sorting()
        {
            int[] arr = { 85, 9, 53, 1, 23, 18, 63, 89, 19 };
  
            BubbleSort.Sort(arr);

            var result = arr.IsSorted();

            Debug.WriteLine(result ? "Array is sorted." : "Array is not sorted");

            Assert.True(result);
        }

        [Fact]
        public void BubbleSort_OptimizedSorting()
        {
            int[] arr = { 11, 17, 18, 26, 23 };

            BubbleSort.OptimizedSort(arr);

            var result = arr.IsSorted();

            Debug.WriteLine(result ? "Array is sorted." : "Array is not sorted");

            Assert.True(result);
        }
    }
}

/*
 * ----------------------------------  MSDN   --------------------------------------------------
 * Arrays are mechanisms that allow you to treat several items as a single collection.
 * The Microsoft® .NET Common Language Runtime (CLR) supports single-dimensional arrays,
 * multidimensional arrays, and jagged arrays (arrays of arrays).
 * All array types are implicitly derived from System.Array, which itself is derived from System.Object.
 * This means that all arrays are always reference types
 * which are allocated on the managed heap, and your app's variable contains a reference to the array
 * and not the array itself.
 * 
 * */
