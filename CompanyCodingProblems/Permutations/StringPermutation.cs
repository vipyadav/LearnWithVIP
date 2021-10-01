using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace LearnWithVIP.CodingProblems.Permutations
{
    public class StringPermutation
    {
        public void GetPermutations(char[] list)
        {
            int x = list.Length - 1;
            GetPermutations(list, 0, x);
        }

        [Fact]
        public void ListAllPermutations()
        {
            string str = "ABC";
            char[] arr = str.ToCharArray();
           // GetPermutations(arr);

           // Debug.WriteLine("Maximum possible Loot value : " + loot.GetMaxLootValues(houseValues));
        }

       

        private void GetPermutations(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.Write(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPermutations(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        private void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }
    }
}
