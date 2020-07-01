using System.Collections.Generic;
using Codility.Katas.Lessons;
using NUnit.Framework;

namespace Codility.Katas.Tests
{
    [TestFixture]
    public class TestNumbrs
    {
        [TestCase(2, 5)]
        public void TestNumbrs1(int l, int r)//, List<int> expectedResult)
        {
            var expectedResult = new List<int> () { 3, 5 };
            var result = Numbrs.OddNumbers(l, r);
            //Assert.IsTrue(result == expectedResult);
            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.IsTrue(result[i] == expectedResult[i]);
            }
        }


        [TestCase(50, new int[] { 20, 19}, new int[] { 24, 20}, 40)]
        public void TestNumbrs2(int n, int[] bundleQuantities, int[] bundleCosts, int expectedResult)
        {
            var result = Numbrs.BudgetShopping(n, bundleQuantities, bundleCosts);
            Assert.IsTrue(result == expectedResult);
        }
    }
}