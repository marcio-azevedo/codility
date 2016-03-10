using Code.Katas.Codility.Lessons;
using NUnit.Framework;

namespace Code.Katas.Codility.Tests.Lessons
{
    [TestFixture]
    public class Tests
    {
        #region Iterations

        [Test]
        public void TestBinaryGapWithSuccess1()
        {
            var n = 1041;
            var expectedResult = 5;
            var result = Iterations.solutionBinaryGap(n);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestBinaryGapWithSuccess2()
        {
            var n = 9;
            var expectedResult = 2;
            var result = Iterations.solutionBinaryGap(n);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestBinaryGapWithSuccess3()
        {
            var n = 529;
            var expectedResult = 4;
            var result = Iterations.solutionBinaryGap(n);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestBinaryGapWithSuccess4()
        {
            var n = 20;
            var expectedResult = 1;
            var result = Iterations.solutionBinaryGap(n);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void TestBinaryGapWithSuccess5()
        {
            var n = 15;
            var expectedResult = 0;
            var result = Iterations.solutionBinaryGap(n);

            Assert.IsTrue(result == expectedResult);
        }

        #endregion

        #region Arrays

        [Test]
        public void TestCyclicRotationWithSuccess1()
        {
            var array = new int[] { 3, 8, 9, 7, 6 };
            var k = 1;
            var expectedResult = new int[] { 6, 3, 8, 9, 7 };
            var result = Arrays.solutionCyclicRotation(array, k);

            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void TestCyclicRotationWithSuccess2()
        {
            var array = new int[] { 3, 8, 9, 7, 6 };
            var k = 3;
            var expectedResult = new int[] { 9, 7, 6, 3, 8 };
            var result = Arrays.solutionCyclicRotation(array, k);

            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void TestOddOccurrencesInArrayWithSuccess1()
        {
            var array = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            var expectedResult = 7;
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

        #region 

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
