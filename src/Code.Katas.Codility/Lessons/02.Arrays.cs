using System.Collections.Generic;
using System.Linq;

namespace Code.Katas.Codility.Lessons
{
    // Arrays - https://codility.com/programmers/lessons/17/
    public class Arrays
    {
        // CyclicRotation (Painless / Easy) - https://codility.com/programmers/task/cyclic_rotation/
        // result 100% - https://codility.com/demo/results/trainingFQFNWF-VRM/
        public static int[] solutionCyclicRotation(int[] A, int K)
        {
            int n = A.Length;
            int[] rotatedArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int rotatedIndex = (i + K) % n;
                rotatedArray[rotatedIndex] = A[i];
            }

            return rotatedArray;
        }

        // OddOccurrencesInArray (Painless / Easy) - https://codility.com/programmers/task/odd_occurrences_in_array/
        // result 100% - https://codility.com/demo/results/training9M477C-SUZ/
        public static int solutionOddOccurrencesInArray(int[] A)
        {
            var occurrences = new Dictionary<int, int>();
            int n = A.Length;

            for (int i = 0; i < n; i++)
            {
                var value = A[i];
                if (occurrences.ContainsKey(value))
                {
                    occurrences[value]++;
                }
                else
                {
                    occurrences.Add(value, 1);
                }
            }

            return occurrences.FirstOrDefault(o => (o.Value % 2) == 1).Key;
        }
    }
}
