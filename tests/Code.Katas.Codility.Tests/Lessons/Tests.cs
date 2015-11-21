using Code.Katas.Codility.Lessons;
using NUnit.Framework;

namespace Code.Katas.Codility.Tests.Lessons
{
    [TestFixture]
    public class Tests
    {
        //[Test]
        //public void TestEquilibriumIndexWithSuccess()
        //{
        //    var array = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };
        //    var arrayLength = 8;

        //    var equilibriumIndex = EquilibriumIndex.Solution(array, arrayLength);

        //    Assert.GreaterOrEqual(equilibriumIndex, 0, $"P({equilibriumIndex}) is not greater or equal then 0.");
        //    Assert.Less(equilibriumIndex, arrayLength, $"P({equilibriumIndex}) is not less then N ({arrayLength}).");
        //    var sums = GetSums(array, arrayLength, equilibriumIndex);
        //    Assert.IsTrue(sums.Item1 == sums.Item2);
        //}

        //[Test]
        //public void TestLeaderWithSuccess()
        //{
        //    var array = new int[] { 1, 3, 1, 5, 1, -6, 1, 1 };

        //    var leader = EquilibriumIndex.SolutionLeader(array);

        //    Assert.Greater(array.Count(o => o == leader), array.Length / 2, $"P({leader}) is not greater then 0.");
        //    Assert.IsTrue(leader == 1);
        //}

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
