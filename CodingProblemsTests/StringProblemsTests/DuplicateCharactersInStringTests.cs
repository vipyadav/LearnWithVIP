using LearnWithVIP.CodingProblems.StringProblems;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingProblemsTests.StringProblemsTests
{
    public class DuplicateCharactersInStringTests
    {
        [Fact]
        public void TestDuplicateCharactersInString()
        {
            var input = "vipinyadav";
            var output1 = DuplicateCharactersInString.RemoveDuplicateChars(input);
            var output2 = DuplicateCharactersInString.RemoveDuplicateCharsByLinq(input);
            var output3 = DuplicateCharactersInString.RemoveDuplicateCharsByHashset(input);

            Assert.Equal("vipnyad", output1);
            Assert.Equal("vipnyad", output2);
            Assert.Equal("vipnyad", output3);
        }
    }
}
