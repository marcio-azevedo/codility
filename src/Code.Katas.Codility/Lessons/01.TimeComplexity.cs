using System;
using System.Linq;

namespace Code.Katas.Codility.Lessons
{
    // https://codility.com/programmers/lessons/1
    public class TimeComplexity
    {
        // TapeEquilibrium (Painless) - https://codility.com/programmers/task/tape_equilibrium
        // result 100% - https://codility.com/demo/results/trainingMWBJ5Z-5PE/
        public static int solutionTapeEquilibrium(int[] A)
        {
            var lsum = 0;
            var rsum = A.Sum(o => o);

            var difference = int.MaxValue;
            for (int i = 0; i < A.Length - 1; i++)
            {
                lsum += A[i];
                rsum -= A[i];
                var temp = Math.Abs(lsum - rsum);
                if (temp < difference)
                {
                    difference = temp;
                }
            }

            return difference;
        }

        // FrogJmp (Painless) - https://codility.com/programmers/task/frog_jmp
        // result 100% - https://codility.com/demo/results/trainingTSUQDM-3UF/
        public static int solutionFrogJump(int X, int Y, int D)
        {
            var result = ((Y - X) / D);
            var rest = ((Y - X) % D);

            return result + ((rest > 0) ? (int)1 : 0);
        }

        // PermMissingElem - https://codility.com/programmers/task/perm_missing_elem
        // result 100% - https://codility.com/demo/results/training4CKURG-MNM/
        public static int solutionPermMissingElem(int[] A)
        {
            var result = 1;
            var totalLength = A.Length + 1;
            var orderedArray = new int?[totalLength];

            foreach (var i in A)
            {
                orderedArray[i - 1] = i;
            }

            for (var i = 0; i < totalLength; i++)
            {
                if (orderedArray[i] == null)
                {
                    result = i + 1;
                    break;
                }
            }

            return result;
        }
    }
}
