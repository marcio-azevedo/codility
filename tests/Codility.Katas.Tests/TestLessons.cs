using System.Collections.Generic;
using Codility.Katas.Lessons;
using NUnit.Framework;

namespace Codility.Katas.Tests
{
    [TestFixture]
    public class TestLessons
    {
        #region Iterations

        [TestCase(1041, 5)]
        [TestCase(9, 2)]
        [TestCase(529, 4)]
        [TestCase(20, 1)]
        [TestCase(15, 0)]
        [TestCase(328, 2)]
        [TestCase(1162, 3)]
        [TestCase(1610612737, 28)]
        public void TestBinaryGapWithSuccess(int n, int expectedResult)
        {
            var result = Iterations.solutionBinaryGap2(n);
            Assert.IsTrue(result == expectedResult);
        }

        #endregion

        #region Arrays

        [TestCase(new int[] { 3, 8, 9, 7, 6 }, 1, new int[] { 6, 3, 8, 9, 7 })]
        [TestCase(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [TestCase(new int[] { 3, 8, 9, 7, 6 }, 1, new int[] { 6, 3, 8, 9, 7 })]
        [TestCase(new int[] { }, 4, new int[] { })]
        public void TestCyclicRotationWithSuccess(int[] array, int k, int[] expectedResult)
        {
            var result = Arrays.solutionCyclicRotation(array, k);
            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void TestOddOccurrencesInArrayWithSuccess1(int[] array, int expectedResult)
        {
            var result = Arrays.solutionOddOccurrencesInArray(array);
            Assert.IsTrue(result == expectedResult);
        }

        #endregion

        #region Time Complexity

        [Test]
        public void TestTapeEquilibriumWithSuccess()
        {
            var array = new int[] { 3, 1, 2, 4, 3 };
            var expectedResult = 1;
            var result = TimeComplexity.solutionTapeEquilibrium(array);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestFrogJumpWithSuccess()
        {
            var X = 10;
            var Y = 85;
            var D = 30;
            var expectedResult = 3;
            var result = TimeComplexity.solutionFrogJump(X, Y, D);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestPermMissingElem()
        {
            var array = new int[] { 2, 3, 1, 5 };
            var expectedResult = 4;
            var result = TimeComplexity.solutionPermMissingElem(array);

            Assert.IsTrue(result == expectedResult);
        }

        #endregion

        #region Counting Elements

        [TestCase(1, new int[] { 1 }, 0)]
        [TestCase(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
        [TestCase(2, new int[] { 2, 2, 2, 2, 2 }, -1)]
        public void TestFrogRiverOneWithSuccess(int x, int[] array, int expectedResult)
        {
            var result = CountingElements.solutionFrogRiverOne(x, array);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(new int[] { 4, 1, 3, 2 }, 1)]
        //[TestCase(new int[] { 4, 1, 3, 2 }, 1)]
        public void TestPermCheckWithSuccess(int[] array, int expectedResult)
        {
            var result = CountingElements.solutionPermCheck(array);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(new int[] { 4, 1, 2, 3 }, 1)]
        [TestCase(new int[] { 4, 1, 3 }, 0)]
        [TestCase(new int[] { 9, 5, 7, 3, 2, 7, 3, 1, 10, 8 }, 0)]
        [TestCase(new int[] { 1, 1 }, 0)]
        public void TestPermCheck(int[] array, int expectedResult)
        {
            var result = CountingElements.solutionPermCheck(array);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(new int[] { 2 }, 1)]
        [TestCase(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [TestCase(new int[] { 1, 2, 3 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 2, 1, 2 }, 4)]
        [TestCase(new int[] { -1, -3 }, 1)]
        public void TestMissingIntegerWithSuccess(int[] array, int expectedResult)
        {
            var result = CountingElements.solutionMissingInteger(array);

            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]
        [TestCase(1, new int[] { 1 }, new int[] { 1 })]
        [TestCase(4, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 1, 1, 1 })]
        [TestCase(4, new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 1, 1, 1 })]
        [TestCase(4, new int[] { 5, 4, 3, 2, 1, 5 }, new int[] { 1, 1, 1, 1 })]
        [TestCase(4, new int[] { 1, 5, 4, 3, 2, 1, 5 }, new int[] { 2, 2, 2, 2 })]
        [TestCase(4, new int[] { 1, 5, 4, 3, 2, 1, 1, 1, 5 }, new int[] { 4, 4, 4, 4 })]
        [TestCase(4, new int[] { 1, 5, 4, 3, 2, 1, 1, 1 }, new int[] { 4, 2, 2, 2 })]
        public void TestMaxCountersWithSuccess(int n, int[] array, int[] expectedResult)
        {
            var result = CountingElements.solutionMaxCounters(n, array);

            Assert.IsTrue(result.Length == expectedResult.Length);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.IsTrue(result[i] == expectedResult[i]);
            }
        }

        #endregion

        #region Prefix Sums

        [TestCase(6, 11, 2, 3)]
        [TestCase(0, 0, 11, 1)] // A = B = 0, K = 11 => 1
        [TestCase(0, 1, 11, 1)] // A = 0, B = 1, K = 11 => 1
        [TestCase(1, 1, 11, 0)] // A = B = 1, K = 11 => 0
        [TestCase(10, 10, 5, 1)]
        [TestCase(11, 345, 17, 20)] //A = 11, B = 345, K = 17 => 20
        [TestCase(10, 10, 5, 1)] //A = 10, B = 10, K in {5,7,20} => 1
        [TestCase(10, 10, 7, 0)] //A = 10, B = 10, K in {5,7,20} => 0
        [TestCase(10, 10, 20, 0)] //A = 10, B = 10, K in {5,7,20} => 0
        [TestCase(101, 123000000, 10000, 12300)] //A = 101, B = 123M+, K = 10K => 12300
        [TestCase(0, 2000000000, 1, 2000000001)] //A = 0, B = MAXINT, K = 1 => 2000000001
        [TestCase(0, 2000000000, 2000000000, 2)] //A = 0, B = MAXINT, K = MAXINT => 2
        public void TestCountDivWithSuccess(int a, int b, int k, int expectedResult)
        {
            var result = PerfixSums.solutionCountDiv(a, b, k);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(new int[] { 0, 1, 0, 1, 1 }, 5)] // A = B = 0, K = 11 => 1
        [TestCase(new int[] { 0, 1, 0, 1, 1, 0, 1 }, 8)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 0 }, 0)]
        [TestCase(new int[] { 0, 1 }, 1)]
        public void TestPassingCarsWithSuccess(int[] a, int expectedResult)
        {
            var result = PerfixSums.solutionPassingCars(a);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }, new int[] { 2, 4, 1 })] // A = B = 0, K = 11 => 1
        [TestCase("A", new int[] { 0 }, new int[] { 0 }, new int[] { 1 })] // A = B = 0, K = 11 => 1
        public void TestGenomicRangeQueryWithSuccess(string s, int[] p, int[] q, int[] expectedResult)
        {
            var result = PerfixSums.solutionGenomicRangeQuery(s, p, q);

            Assert.IsTrue(result.Length == expectedResult.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsTrue(result[i] == expectedResult[i]);
            }
        }

        [TestCase(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 1)]
        [TestCase(new int[] { -3, -5, -8, -4, -10 }, 2)]
        public void TestMinAvgTwoSlicesWithSuccess(int[] a, int expectedResult)
        {
            var result = PerfixSums.solutionMinAvgTwoSlice(a);
            Assert.IsTrue(result == expectedResult);
        }

        #endregion

        #region Sorting

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 2, 1, 1, 2, 3, 1 }, 3)]
        [TestCase(new int[] { -2, 1, -1, 2, 3, 1 }, 5)]
        public void TestSortingDistinctWithSuccess(int[] a, int expectedResult)
        {
            var result = Sorting.Distinct(a);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(new int[] { -50, -20, 1, 2, 3 }, 3000)]
        [TestCase(new int[] { -1, 1, 1 }, -1)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { -3, 1, 2, -2, 5, 6 }, 60)]
        public void TestSortingMaxProductOfThreeWithSuccess(int[] a, int expectedResult)
        {
            var result = Sorting.MaxProductOfThree(a);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(new int[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [TestCase(new int[] { 10, 50, 5 }, 0)]
        [TestCase(new int[] { 10, 50, 5, 1 }, 0)]
        [TestCase(new int[] { 1, 1, 1 }, 1)]
        [TestCase(new int[] { int.MaxValue-2, int.MaxValue-1, int.MaxValue }, 1)]
        public void TestSortingTriangleWithSuccess(int[] a, int expectedResult)
        {
            var result = Sorting.Triangle(a);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
        [TestCase(new int[] { 1, int.MaxValue, 2, 1, 4, 0 }, 11)]
        public void TestSortingNumberOfDiscIntersectionsWithSuccess(int[] a, int expectedResult)
        {
            var result = Sorting.NumberOfDiscIntersections(a);
            Assert.IsTrue(result == expectedResult);
        }

        #endregion

        #region Stacks and Queues

        [TestCase("abcd", 'd')]
        [TestCase("", '\0')]
        public void TestStacksPopWithSuccess(string s, char expectedResult)
        {
            var result = StacksQueues.StackPop(ref s);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase("abcd", 'e', "abcde", 4)]
        [TestCase("", 'a', "a", 0)]
        public void TestStacksPushWithSuccess(string s, char c, string expectedResult, int expectedIndex)
        {
            var result = StacksQueues.StackPush(ref s, c);
            Assert.IsTrue(expectedIndex.Equals(result));
            Assert.IsTrue(expectedResult.Equals(s));
        }

        [TestCase("abcd", 'a')]
        [TestCase("", '\0')]
        public void TestQueuesPopWithSuccess(string s, char expectedResult)
        {
            var result = StacksQueues.QueuePop(ref s);
            Assert.IsTrue(result == expectedResult);
        }

        [TestCase("bcd", 'a', "abcd", 0)]
        [TestCase("", 'a', "a", 0)]
        public void TestQueuesPushWithSuccess(string s, char c, string expectedResult, int expectedIndex)
        {
            var result = StacksQueues.QueuePush(ref s, c);
            Assert.IsTrue(expectedIndex.Equals(result));
            Assert.IsTrue(expectedResult.Equals(s));
        }

        [TestCase("(()())()", 1)]
        [TestCase("{{({}[]{})}}[]{}", 1)]
        [TestCase("({{({}[]{})}}[]{})", 1)]
        [TestCase("()()()", 1)]
        [TestCase("", 1)]
        [TestCase("{[()()]}", 1)]
        [TestCase("([)()]", 0)]
        [TestCase("([)()", 0)]
        public void TestStacksQueuesBracketsWithSuccess(string s, int expectedResult)
        {
            var result = StacksQueues.Brackets(s);
            Assert.IsTrue(result == expectedResult);
        }

        #endregion
    }
}
