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
        // result 62% - https://codility.com/demo/results/trainingZ5XPSJ-CYP/
        public static int[] solutionGenomicRangeQuery(string S, int[] P, int[] Q)
        {
            var m = P.Length;
            var n = S.Length;
            int[] result = new int[m];
            int[] impact = new int[n];

            #region O(N)

            for (int i = 0; i < n; i++)
            {
                var minimalImpact = 4;
                switch (S[i])
                {
                    case 'A':
                        minimalImpact = 1;
                        break;
                    case 'C':
                        minimalImpact = 2;
                        break;
                    case 'G':
                        minimalImpact = 3;
                        break;
                    case 'T':
                        minimalImpact = 4;
                        break;
                    default:
                        minimalImpact = 4;
                        break;
                }

                impact[i] = minimalImpact;
            }

            #endregion

            #region O(M)

            for (int i = 0; i < m; i++)
            {
                var p = P[i];
                var q = Q[i];

                result[i] = 4;
                // O(N)
                for (int j = p; j <= q; j++)
                {
                    result[i] = (result[i] < impact[j]) ? result[i] : impact[j];
                }
            }

            #endregion

            // O(N+(M*N))
            return result;
        }

        // Min Avg Two Slice (Respectable / Medium) - https://codility.com/programmers/task/min_avg_two_slice/
        // result 0% - 
        public static int solutionMinAvgTwoSlice(int[] A)
        {
            int result = 0;

            // TODO

            return result;
        }
    }
}
