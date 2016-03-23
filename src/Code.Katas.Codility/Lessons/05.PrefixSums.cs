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
        // result 0% - 
        public static int[] solutionGenomicRangeQuery(string S, int[] P, int[] Q)
        {
            int[] result = new int[] { };

            // TODO

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
