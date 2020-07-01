using System.Collections.Generic;
using Codility.Katas.Lessons;
using NUnit.Framework;

namespace Codility.Katas.Tests
{
    [TestFixture]
    public class TestSortingAlgorithms
    {
        [TestCase(50, new int[] { 20, 19}, new int[] { 24, 20}, 40)]
        public void TestNumbrs2(int n, int[] bundleQuantities, int[] bundleCosts, int expectedResult)
        {
            var result = Numbrs.BudgetShopping(n, bundleQuantities, bundleCosts);
            Assert.IsTrue(result == expectedResult);
        }
    }
}