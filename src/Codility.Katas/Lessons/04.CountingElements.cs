namespace Codility.Katas.Lessons
{
    // CountingElements - https://codility.com/programmers/lessons/2
    public class CountingElements
    {
        public static int solutionFrogRiverOne(int X, int[] A) {
            var seconds = -1;
            var length = A.Length;
            int[] countingArray = new int[length];
            
            if (X <= length) {

                for (int i = 0; i < length; i++)
                {
                    countingArray[i] = -1;
                }

                for (int second = 0; second < length; second++)
                {
                    var position = A[second]-1;
                    if (countingArray[position] < 0) countingArray[position] = second;
                }

                for (int i = 0; i < X; i++)
                {
                    if (countingArray[i] < 0) {
                        seconds = -1;
                        break;
                    }
                    else if (seconds < countingArray[i]) {
                        seconds = countingArray[i];
                    }
                }
            }

            return seconds;
        }

        public static int[] solutionMaxCounters(int N, int[] A) {
            var length = A.Length;
            var result = new int[N];
            var maxCounters = new int[length];
            var maxCounter = 0;

            for (int k = 0; k < length; k++)
            {
                var value = A[k];
                if (1 <= value && value <= N) {
                    result[value-1]++;
                    if (maxCounter < result[value-1]) { maxCounter = result[value-1]; }
                } else if (value == (N + 1)) {
                    for (int i = 0; i < N; i++)
                    {
                        result[i] = maxCounter;
                    }
                }
            }

            return result;
        }

        public static int solutionMissingInteger(int[] A) {
            int length = A.Length;
            int[] counters = new int[length];
            var missingInteger = length+1;

            for (int i = 0; i < length; i++)
            {
                var value = A[i]-1;
                if (value >= 0 && value < length) {
                    counters[value]++;
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (counters[i] == 0) { 
                    missingInteger = i+1;
                    break;
                }
            }

            return missingInteger;
        }

        public static int solutionPermCheck(int[] A) {
            var isPermutation = 1;
            var length = A.Length;
            var counter = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                var value = A[i];
                if (value <= length)
                {
                    counter[value-1]++;
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (counter[i] == 0 || counter[i] > 1)
                {
                    isPermutation = 0;
                    break;
                }
            }

            return isPermutation;
        }

        // --
        // Frog River One (Painless / Easy) - https://codility.com/programmers/task/frog_river_one
        // result 100% - https://codility.com/demo/results/trainingTRQEXA-XEF/
        public static int solutionFrogRiverOne1(int X, int[] A)
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
        public static int solutionPermCheck1(int[] A)
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
        public static int solutionMissingInteger1(int[] A)
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
        public static int[] solutionMaxCounters1(int N, int[] A)
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
