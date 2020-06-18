using System.Collections.Generic;
using System.Linq;

namespace Codility.Katas.Lessons
{
    // Arrays - https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
    public class Arrays
    {
        public static int[] solutionCyclicRotation(int[] A, int K)
        {
            var result = new List<int>();
            var length = A.Length;
            var newK = K;

            if (newK > 0 && length > 0) {

                while (newK > length) { newK = newK-length; }

                for (int i = 1; i <= length; i++) {
                    var index = (length - newK + i) <= length ? (length - newK + i) : (i - newK);
                    result.Add(A[index-1]);
                }
            }

            return (newK > 0) ? result.ToArray() : A;
        }

        public static int solutionOddOccurrencesInArray(int[] A)
        {
            var result = 0;
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++) {
                if (dic.ContainsKey(A[i])) {
                    dic[A[i]]++;
                }
                else {
                    dic.Add(A[i], 1);
                }
            }

            result = dic.FirstOrDefault(v => (v.Value % 2) == 1).Key;

            return result;
        }

        // CyclicRotation (Painless / Easy) - https://codility.com/programmers/task/cyclic_rotation/
        // result 100% - https://codility.com/demo/results/trainingFQFNWF-VRM/
        public static int[] solutionCyclicRotation1(int[] A, int K)
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
        public static int solutionOddOccurrencesInArray1(int[] A)
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
