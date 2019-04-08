using System;
using System.Diagnostics;
using Searching;
using Xunit;

namespace DataStructureTests
{
    public class BinarySearchTest
    {
        [Fact]
        public void RecursiveBinarySearch_ElementFound()
        {
            int[] arr = { 5, 9, 13, 18, 23, 28, 43, 85, 89 };
            var length = arr.Length;
            const int searchItem = 43;

            var result = BinarySearch.RecursiveBinarySearch(arr, 0, length - 1, searchItem);

            if (result == -1)
                Debug.WriteLine("Item is not found.");
            else
                Debug.WriteLine("Item found at index " + result);

            Assert.Equal(6, result);
        }

        [Fact]
        public void RecursiveBinarySearch_ElementNotFound()
        {
            int[] arr = { 5, 9, 13, 18, 23, 28, 43, 85, 89 };
            var length = arr.Length;
            const int searchItem = 2;

            var result = BinarySearch.RecursiveBinarySearch(arr, 0, length - 1, searchItem);

            if (result == -1)
                Debug.WriteLine("Item is not found.");
            else
                Debug.WriteLine("Item found at index " + result);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void IterativeBinarySearch_ElementFound()
        {
            int[] arr = { 3, 7, 9, 15, 21, 26, 32, 45, 53, 72 };
            const int searchItem = 9;
            var result = BinarySearch.IterativeBinarySearch(arr, searchItem);
            if (result == -1)
                Debug.WriteLine("Item is not found.");
            else
                Debug.WriteLine("Item found at " + "index " + result);

            Assert.Equal(2, result);
        }


        [Fact]
        public void TestIterativeBinarySearch_ElementNotFound()
        {
            int[] arr = { 3, 7, 9, 15, 21, 26, 32, 45, 53, 72 };
            const int searchItem = 10;
            var result = BinarySearch.IterativeBinarySearch(arr, searchItem);
            if (result == -1)
                Debug.WriteLine("Item is not found.");
            else
                Debug.WriteLine("Item found at " + "index " + result);

            Assert.Equal(-1, result);
        }
    }
}
