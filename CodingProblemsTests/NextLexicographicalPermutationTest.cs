using CodingProblems;
using System;
using System.Diagnostics;
using Xunit;

namespace CodingProblemsTests
{
    public class NextLexicographicalPermutationTest
    {
        [Fact]
        public void TestNextLexicographicalPermutation()
        {

            Assert.Equal("ba", NextLexicographicalPermutation.BiggerIsGreater("ab"));
            Assert.Equal("no answer", NextLexicographicalPermutation.BiggerIsGreater("bb"));
            Assert.Equal("hegf", NextLexicographicalPermutation.BiggerIsGreater("hefg"));
            Assert.Equal("dhkc", NextLexicographicalPermutation.BiggerIsGreater("dhck"));
            Assert.Equal("hcdk", NextLexicographicalPermutation.BiggerIsGreater("dkhc"));
        }
    }
}
