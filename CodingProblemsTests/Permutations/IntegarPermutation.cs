using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace LearnWithVIP.CodingProblems.Permutations
{
    public class IntegarPermutation
    {
        [Fact]
        public void ListAllPermutations()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            PrintAllPermutations(list.ToArray());
        }

        private void PrintAllPermutations(int[] list)
        {
            int endIndex = list.Length - 1;
            GetPermutations(list, 0, endIndex);
        }     
           
        private void GetPermutations(int[] list, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
                Debug.WriteLine(string.Join("", list));
            else
                for (int i = startIndex; i <= endIndex; i++)
                {
                    Swap(ref list[startIndex], ref list[i]);
                    GetPermutations(list, startIndex + 1, endIndex);
                    Swap(ref list[startIndex], ref list[i]);
                }
        }

        private void Swap(ref int a, ref int b)
        {
            if (a == b) return;
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
