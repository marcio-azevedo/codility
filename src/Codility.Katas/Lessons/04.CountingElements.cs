namespace Codility.Katas.Lessons
{
    // CountingElements - https://codility.com/programmers/lessons/2
    public class CountingElements
    {
        // Frog River One (Painless / Easy) - https://codility.com/programmers/task/frog_river_one
        // result 100% - https://codility.com/demo/results/trainingTRQEXA-XEF/
        public static int solutionFrogRiverOne(int X, int[] A)
        {
            int result = -1;
            int[] path = new int[X];
            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                var leafPosition = A[i];
                if (path[leafPosition - 1] == 0)
                {
                    path[leafPosition - 1] = 1;
                    sum++;
                }

                if (sum == X)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        // Perm Check (Painless / Easy) - https://codility.com/programmers/task/perm_check
        // result 100% - https://codility.com/demo/results/training62ADB9-TUD/
        public static int solutionPermCheck(int[] A)
        {
            int result = 0;
            int sum = 0;
            int maxNumber = 0;
            int length = A.Length;
            int[] permutation = new int[length + 1];

            for (int i = 0; i < length; i++)
            {
                var position = A[i] - 1;
                var value = position + 1;
                if (position >= 0 && position < length && permutation[position] == 0)
                {
                    permutation[position] = 1;
                    sum++;
                }

                if (value > maxNumber)
                {
                    maxNumber = value;
                }
            }

            if (sum == maxNumber && sum == length)
            {
                result = 1;
            }

            return result;
        }

        // Missing Integer (Painless / Easy) - https://codility.com/programmers/task/missing_integer
        // result 100% - https://codility.com/demo/results/trainingQG6BSB-GKJ/
        public static int solutionMissingInteger(int[] A)
        {
            int length = A.Length;
            int[] permutation = new int[100000];
            int i = 0;

            for (; i < length; i++)
            {
                var value = A[i];
                var position = value - 1;
                if (position >= 0 && position < 100000 &&
                    permutation[position] == 0)
                {
                    permutation[position] = 1;
                }
            }

            i = 0;
            while (i < 100000 && permutation[i] != 0)
            {
                i++;
            }

            return i + 1;
        }

        // Max Counters (Respectable / Medium) - https://codility.com/programmers/task/max_counters
        // result 100% - https://codility.com/demo/results/trainingSTWK6Z-AA8/
        public static int[] solutionMaxCounters(int N, int[] A)
        {
            int length = A.Length;
            int[] counters = new int[N];
            int maxCounter = 0;
            int lastMaxCounterApplied = maxCounter;

            for (int k = 0; k < length; k++)
            {
                var x = A[k];
                if (1 <= x && x <= N)
                {
                    counters[x - 1]++;
                    if (counters[x - 1] > maxCounter)
                    {
                        maxCounter = counters[x - 1];
                    }
                }
                else if ((x == N + 1) &&
                         (lastMaxCounterApplied != maxCounter))
                {
                    for (int i = 0; i < N; i++)
                    {
                        counters[i] = maxCounter;
                    }
                    lastMaxCounterApplied = maxCounter;
                }
            }

            return counters;
        }
    }
}
