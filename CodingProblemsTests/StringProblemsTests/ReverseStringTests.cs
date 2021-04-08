using LearnWithVIP.CodingProblems.StringProblems;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingProblemsTests.StringProblemsTests
{
    public class ReverseStringTests
    {
        [Fact]
        public void TestReverseStringTests()
        {
            var reverse = ReverseString.Reverse("vipin");
            PalindromeString.IsPalindrome("madam");
            PalindromeString.IsPalindrome("Malayalam");
            OccurrenceString.MaxOccuringChar("Welcome to http://vipinkumaryadav.com");
            OccurrenceString.UniqueCharacters("hutg9mnd!nk9");
        } 
    }
}
