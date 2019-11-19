using System;
using System.Diagnostics;
using System.Linq;
using LINQ;
using Xunit;

namespace LINQTests
{
    public class PrimeNumberTests
    {
        [Fact]
        public void Test1()
        {
            var dd= PrimeNumber.GetAllPrimeNumbers(Enumerable.Range(1,49).ToList());

        }

        [Fact]
        public void Test2()
        {
            ListFiltering.StringItemsNotInList1();

        }
    }
}
