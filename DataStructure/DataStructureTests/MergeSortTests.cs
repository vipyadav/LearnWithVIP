using System;
using System.Diagnostics;
using Common.Extensions;
using LearnWithVIP.DataStructure.Searching;
using LearnWithVIP.DataStructure.Sorting;
using Xunit;

namespace LearnWithVIP.DataStructureTests
{
    public class MergeSortTests
    {
        [Fact]
        public void MergeSort_Sorting()
        {
            int[] arr = { 85, 9, 53, 1, 23, 18, 63, 89, 19 };

            MergeSort.Sort(arr);

            var result = arr.IsSorted();

            Debug.WriteLine(result ? "Array is sorted." : "Array is not sorted");

            Assert.True(result);
        }

        
    }
}
