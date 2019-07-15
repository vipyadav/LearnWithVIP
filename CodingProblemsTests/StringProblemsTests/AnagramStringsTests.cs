using LearnWithVIP.CodingProblems.StringProblems;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingProblemsTests.StringProblemsTests
{
    public class AnagramStringsTests
    {
        [Fact]
        public void TestAnagramsUsingSorting()
        {
            Assert.True(AnagramStrings.AreStringsAnagramsUsingSorting("silent", "listen"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingSorting("word", "wrdo"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingSorting("mary", "army"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingSorting("stop", "tops"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingSorting("boat", "btoa"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingSorting("pure", "in"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingSorting("fill", "fil"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingSorting("b", "bbb"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingSorting("ccc", "ccccccc"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingSorting("a", "a"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingSorting("sleep", "slep"));
        }

        [Fact]
        public void TestAnagramsUsingCountChars()
        {
            Assert.True(AnagramStrings.AreStringsAnagramsUsingCountChars("silent", "listen"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingCountChars("word", "wrdo"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingCountChars("mary", "army"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingCountChars("stop", "tops"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingCountChars("boat", "btoa"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingCountChars("pure", "in"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingCountChars("fill", "fil"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingCountChars("b", "bbb"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingCountChars("ccc", "ccccccc"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingCountChars("a", "a"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingCountChars("sleep", "slep"));
        }

        [Fact]
        public void TestAnagramsUsingXor()
        {
            Assert.True(AnagramStrings.AreStringsAnagramsUsingXor("silent", "listen"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingXor("word", "wrdo"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingXor("mary", "army"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingXor("stop", "tops"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingXor("boat", "btoa"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingXor("pure", "in"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingXor("fill", "fil"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingXor("b", "bbb"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingXor("ccc", "ccccccc"));
            Assert.True(AnagramStrings.AreStringsAnagramsUsingXor("a", "a"));
            Assert.False(AnagramStrings.AreStringsAnagramsUsingXor("sleep", "slep"));
        }
    }
}
