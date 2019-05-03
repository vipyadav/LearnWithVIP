using CodingProblems;
using System;
using System.Diagnostics;
using Xunit;

namespace CodingProblemsTests
{
    public class HighestOccurrenceTest
    {
        [Fact]
        public void GetMaxFrequencyOfGreatestNumberTest()
        {
            int[] arr = { 3, 2, 1, 2, 2, 3, 1, 3 };

            Assert.Equal(3, HighestOccurrence.GetMaxFrequencyOfGreatestNumber(arr));
        }

        [Fact]
        public void GetDigitWhichHasHighestOccurrenceBruteForceTest()
        {
            int[] arr = { 3, 2, 1, 2, 2, 3, 1, 3, 2, 1, 2 };

            Assert.Equal(2, HighestOccurrence.GetDigitWhichHasHighestOccurrenceBruteForce(arr));
        }

        [Fact]
        public void FindHighestRepeatingElementTest()
        {
            int[] input_array = { 42, 3, 42, 1, 42, 3, 42 };

            Assert.Equal(42, HighestOccurrence.FindHighestRepeatingElement(input_array));

        }
    }
}
