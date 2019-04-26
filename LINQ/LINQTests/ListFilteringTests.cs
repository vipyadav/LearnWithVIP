using System;
using System.Diagnostics;
using LINQ;
using Xunit;

namespace LINQTests
{
    public class ListFilteringTests
    {
        [Fact]
        public void Test1()
        {
           ListFiltering.ItemsNotInList1();

        }

        [Fact]
        public void Test2()
        {
            ListFiltering.StringItemsNotInList1();

        }
    }
}
