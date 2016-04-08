using Code.Katas.Codility.Lessons;
using NUnit.Framework;

namespace Code.Katas.Codility.Tests.Lessons
{
    [TestFixture]
    public class Tests
    {
        #region Iterations

        [TestCase(1041, 5)]
        [TestCase(9, 2)]
        [TestCase(529, 4)]
        [TestCase(20, 1)]
        [TestCase(15, 0)]
        public void TestBinaryGapWithSuccess(int n, int expectedResult)
        {
            var result = Iterations.solutionBinaryGap(n);
            Assert.IsTrue(result == expectedResult);
        }

        #endregion

        #region Arrays

        [TestCase(new int[] { 3, 8, 9, 7, 6 }, 1, new int[] { 6, 3, 8, 9, 7 })]
        [TestCase(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [TestCase(new int[] { 3, 8, 9, 7, 6 }, 1, new int[] { 6, 3, 8, 9, 7 })]
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

        [Test]
        public void TestFrogRiverOneWithSuccess()
        {
            var array = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            var x = 5;
            var expectedResult = 6;
            var result = CountingElements.solutionFrogRiverOne(x, array);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestPermCheckWithSuccess()
        {
            var array = new int[] { 4, 1, 3, 2 };
            var expectedResult = 1;
            var result = CountingElements.solutionPermCheck(array);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestPermCheckWithError()
        {
            var array = new int[] { 4, 1, 3 };
            var expectedResult = 0;
            var result = CountingElements.solutionPermCheck(array);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestPermCheckWithError1()
        {
            var array = new int[] { 9, 5, 7, 3, 2, 7, 3, 1, 10, 8 };
            var expectedResult = 0;
            var result = CountingElements.solutionPermCheck(array);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestPermCheckWithError2()
        {
            var array = new int[] { 1, 1 };
            var expectedResult = 0;
            var result = CountingElements.solutionPermCheck(array);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestMissingIntegerWithSuccess()
        {
            var array = new int[] { 1, 3, 6, 4, 1, 2 };
            var expectedResult = 5;
            var result = CountingElements.solutionMissingInteger(array);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestMaxCountersWithSuccess()
        {
            var array = new int[] { 3, 4, 4, 6, 1, 4, 4 };
            int n = 5;
            var expectedResult = new int[] { 3, 2, 2, 4, 2 };
            var result = CountingElements.solutionMaxCounters(n, array);

            Assert.IsTrue(result.Length == expectedResult.Length);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.IsTrue(result[i] == expectedResult[i]);
            }
        }

        [Test]
        public void TestMaxCountersWithSuccess1()
        {
            var array = new int[] { 1 };
            int n = 1;
            var expectedResult = new int[] { 1 };
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

        #endregion

        //private Tuple<int, int> GetSums(int[] array, int length, int p)
        //{
        //    int result1 = 0;
        //    int result2 = 0;

        //    switch (p)
        //    {
        //        case 0:
        //            result1 = 0;
        //            result2 = SumArrayValues(array, p + 1, length);
        //            break;
        //        default:
        //            if (p == (length - 1))
        //            {
        //                result1 = SumArrayValues(array, 0, p - 1);
        //                result2 = 0;
        //            }
        //            else
        //            {
        //                result1 = SumArrayValues(array, 0, p - 1);
        //                result2 = SumArrayValues(array, p + 1, length);
        //            }

        //            break;
        //    }

        //    return new Tuple<int, int>(result1, result2);
        //}

        //private int SumArrayValues(int[] array, int start, int end)
        //{
        //    int result = (start == end) ? array[start] : 0;

        //    for (int i = start; i < end; i++)
        //    {
        //        result += array[i];
        //    }

        //    return result;
        //}
    }
}
