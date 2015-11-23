namespace Code.Katas.Codility.Lessons
{
    // https://codility.com/programmers/lessons/2
    public class CountingElements
    {
        // Frog River One (Painless) - https://codility.com/programmers/task/frog_river_one
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

        // Perm Check (Painless) - https://codility.com/programmers/task/perm_check
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
    }
}
