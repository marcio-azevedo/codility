using System;
using System.Linq;

namespace Codility.Katas.Lessons
{
    // TimeComplexity - https://codility.com/programmers/lessons/1
    public class TimeComplexity
    {
        public static int solutionFrogJump(int X, int Y, int D) {
            var jumps = ((Y - X) % D) > 0 ? ((Y - X) / D) + 1 : (Y - X) / D;

            return jumps;
        }

        public static int solutionPermMissingElem(int[] A) {
            var total = 0;
            var sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                total += A[i];
                sum += i+1;
            }

            return A.Length - (total - sum - 1);
        }
        
        public static int solutionTapeEquilibrium(int[] A) {
            var minimalDifference = int.MaxValue;
            var length = A.Length;
            var accruedValue = 0;
            int[] tapeEquilibriumArray = new int[length];

            for (int i = 0; i < A.Length; i++)
            {
                accruedValue += A[i];
                tapeEquilibriumArray[i] = accruedValue;
            }

            accruedValue = 0;
            for (int i = A.Length-1; i > 0; i--)
            {
                accruedValue += A[i];
                minimalDifference = (Math.Abs(tapeEquilibriumArray[i-1] - accruedValue) < minimalDifference) ? Math.Abs(tapeEquilibriumArray[i-1] - accruedValue) : minimalDifference;
            }

            return minimalDifference;
        }
        // --

        // TapeEquilibrium (Painless / Easy) - https://codility.com/programmers/task/tape_equilibrium
        // result 100% - https://codility.com/demo/results/trainingMWBJ5Z-5PE/
        public static int solutionTapeEquilibrium1(int[] A)
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

        // FrogJmp (Painless / Easy) - https://codility.com/programmers/task/frog_jmp
        // result 100% - https://codility.com/demo/results/trainingTSUQDM-3UF/
        public static int solutionFrogJump1(int X, int Y, int D)
        {
            var result = ((Y - X) / D);
            var rest = ((Y - X) % D);

            return result + ((rest > 0) ? (int)1 : 0);
        }

        // PermMissingElem (Painless / Easy) - https://codility.com/programmers/task/perm_missing_elem
        // result 100% - https://codility.com/demo/results/training4CKURG-MNM/
        public static int solutionPermMissingElem1(int[] A)
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
