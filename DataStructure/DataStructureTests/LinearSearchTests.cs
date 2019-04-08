using System;
using System.Diagnostics;
using Searching;
using Xunit;

namespace DataStructureTests
{
    public class LinearSearchTests
    {
        [Fact]
        public void LinearSearch_ElementFound()
        {
            int[] arr = { 5, 9, 13, 18, 23, 28, 43, 85, 89 };

            const int searchItem = 43;

            var result = LinearSearch.Search(arr, searchItem);

            if (result == -1)
                Debug.WriteLine("Item is not found.");
            else
                Debug.WriteLine("Item found at index " + result);

            Assert.Equal(6, result);
        }

        [Fact]
        public void LinearSearch_ElementNotFound()
        {
            int[] arr = { 5, 9, 13, 18, 23, 28, 43, 85, 89 };
            const int searchItem = 2;
            var result = LinearSearch.Search(arr, searchItem);

            if (result == -1)
                Debug.WriteLine("Item is not found.");
            else
                Debug.WriteLine("Item found at index " + result);

            Assert.Equal(-1, result);
        }
    }
}
