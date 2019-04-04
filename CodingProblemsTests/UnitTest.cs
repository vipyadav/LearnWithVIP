using CodingProblems;
using System;
using System.Diagnostics;
using Xunit;

namespace CodingProblemsTests
{
    public class UnitTest
    {
        [Fact]
        public void TestLoot()
        {
            var loot = new Loot();
            int[] houseValues = { 6, 5, 1, 3, 2, 8, 4 };

            Debug.WriteLine("Maximum possible Loot value : " + loot.GetMaxLootValues(houseValues));
        }
    }
}
