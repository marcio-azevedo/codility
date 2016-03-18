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
    }
}
