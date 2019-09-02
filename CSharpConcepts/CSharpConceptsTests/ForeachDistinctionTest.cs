using CSharpConcepts;
using System;
using Xunit;

namespace LearnWithVIP.CSharpConceptsTests
{
    public class ForeachDistinctionTest
    {
        [Fact]
        public void Test1()
        {
            var obj = new ForeachDistinction();
            obj.DisplayItems();
        }

        [Fact]
        public void Test2()
        {
            var obj = new IEnumerableEx();
            obj.GetCars();
        }
    }
}
