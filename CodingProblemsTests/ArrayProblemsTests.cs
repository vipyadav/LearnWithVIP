using LearnWithVIP.CodingProblems.ArrayProblems;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingProblemsTests
{
    public class ArrayProblemsTests
    {
        [Fact]
        public void TestDuplicateCharactersInString()
        {
            ArrayProblems.FindDuplicateElements();
            ArrayProblems.FindDuplicateElementsByLinq();
            ArrayProblems.FindDuplicateElementsWithOccurrence();
        }

        [Fact]
        public void Main()
        {
            int[] arr = {12, 16, 22, 30, 35, 39, 42, 45, 48, 50, 53, 55, 56};
            int n = arr.Length;
            int x = 35;
            ArrayProblems.PrintKclosest(arr, x, 4, n);
        }
    }
}
