using System;
using System.Diagnostics;
using Common.Extensions;
using LearnWithVIP.DataStructure.Searching;
using LearnWithVIP.DataStructure.Sorting;
using Xunit;

namespace LearnWithVIP.DataStructureTests
{
    public class InsertionSortTests
    {
        [Fact]
        public void InsertionSort_Sorting()
        {
            int[] arr = { 85, 9, 53, 1, 23, 18, 63, 89, 19 };

            InsertionSort.Sort(arr);

            var result = arr.IsSorted();

            Debug.WriteLine(result ? "Array is sorted." : "Array is not sorted");

            Assert.True(result);
        }

        [Fact]
        public void InsertionSort_Sorting2()
        {
            int[] arr = { 5, 1, 6, 2, 4, 3 };

            InsertionSort.Sort(arr);

            var result = arr.IsSorted();

            Debug.WriteLine(result ? "Array is sorted." : "Array is not sorted");

            Assert.True(result);
        }
    }
}
