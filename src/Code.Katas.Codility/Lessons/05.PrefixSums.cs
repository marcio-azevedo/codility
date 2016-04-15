using System.Linq;

namespace Code.Katas.Codility.Lessons
{
    // Prefix Sums - https://codility.com/programmers/lessons/3/
    public class PerfixSums
    {
        // Count Div (Painless / Easy) - https://codility.com/programmers/task/count_div/
        // result 100% - https://codility.com/demo/results/trainingHDGERS-UT2/
        public static int solutionCountDiv(int A, int B, int K)
        {
            int result1 = (B / K);
            int result2 = ((A % K) != 0) ? (A / K) : ((A - 1) / K);
            int result3 = 0;

            switch (A)
            {
                case 0:
                    result3 = (B / K) - (A / K) + 1;
                    break;
                default:
                    result3 = result1 - result2;
                    break;
            }

            return result3;
        }

        // Passing Cars (Painless / Easy) - https://codility.com/programmers/task/passing_cars/
        // result 100% - https://codility.com/demo/results/trainingF54EKW-A9G/
        public static int solutionPassingCars(int[] A)
        {
            int n = A.Length;
            uint cumulative = 0;
            int result = 0;
            uint numberOfCarsTravellingWest = 0;
            //int[] sufixSums = new int[n + 1];

            for (int i = n - 1; i >= 0; i--)
            {
                if (A[i] == 0)
                {
                    cumulative += numberOfCarsTravellingWest;
                }
                else
                {
                    numberOfCarsTravellingWest++;
                }
            }

            result = (cumulative > 1000000000) ? -1 : (int)cumulative;

            return result;
        }

        // Genomic Range Query (Respectable / Medium) - https://codility.com/programmers/task/genomic_range_query/
        // result 100% - https://codility.com/demo/results/trainingJHSECB-VXK/
        public static int[] solutionGenomicRangeQuery(string S, int[] P, int[] Q)
        {
            var m = P.Length;
            var n = S.Length;
            int[] result = new int[m];
            int[,] arr = new int[n, 4];

            #region O(N)

            for (int i = 0; i < n; i++)
            {
                char c = S[i];
                if (c == 'A') arr[i, 0] = 1;
                if (c == 'C') arr[i, 1] = 1;
                if (c == 'G') arr[i, 2] = 1;
                if (c == 'T') arr[i, 3] = 1;
            }

            // compute prefixes
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] += arr[i - 1, j];
                }
            }

            #endregion

            #region O(M)

            for (int i = 0; i < m; i++)
            {
                int x = P[i];
                int y = Q[i];

                for (int a = 0; a < 4; a++)
                {
                    int sub = 0;
                    if (x - 1 >= 0) sub = arr[x - 1, a];
                    if (arr[y, a] - sub > 0)
                    {
                        result[i] = a + 1;
                        break;
                    }
                }
            }

            #endregion

            return result;
        }

        // Min Avg Two Slice (Respectable / Medium) - https://codility.com/programmers/task/min_avg_two_slice/
        // result 50% - https://codility.com/demo/results/training2UENTN-4E2/
        public static int solutionMinAvgTwoSlice(int[] A)
        {
            int result = 0;
            int n = A.Length;
            decimal[,] averageSlices = new decimal[n, n];
            var minimalAverage = decimal.MaxValue;

            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    var total = A.Take(j + 1).Skip(i).Sum();
                    averageSlices[i, j] = ((decimal)total) / (j - i + 1);
                    if (averageSlices[i, j] < minimalAverage)
                    {
                        minimalAverage = averageSlices[i, j];
                        result = i;
                    }
                }
            }

            return result;
        }
    }
}
