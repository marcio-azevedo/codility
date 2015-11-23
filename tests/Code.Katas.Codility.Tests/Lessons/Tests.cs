﻿using Code.Katas.Codility.Lessons;
using NUnit.Framework;

namespace Code.Katas.Codility.Tests.Lessons
{
    [TestFixture]
    public class Tests
    {
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