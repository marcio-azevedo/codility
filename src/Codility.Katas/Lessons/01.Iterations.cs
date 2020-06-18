using System;
using System.Collections.Generic;

namespace Codility.Katas.Lessons
{
    // Iterations - https://codility.com/programmers/lessons/18/
    public class Iterations
    {
        // BinaryGap (Painless / Easy) - https://codility.com/programmers/task/binary_gap/
        // result 100% - https://codility.com/demo/results/trainingPKN45Q-TPT/
        public static int solutionBinaryGap(int N)
        {
            int longestBinaryGap = 0;
            int currentBinaryGap = 0;
            bool potentialGap = false;
            var bitArray = new List<int>();
            int divisionResult = 0;
            int remainder = 0;

            remainder = N % 2;
            bitArray.Add(remainder);
            divisionResult = N / 2;

            while (divisionResult > 0)
            {
                remainder = divisionResult % 2;
                bitArray.Add(remainder);
                divisionResult = divisionResult / 2;
            }

            foreach (var b in bitArray)
            {
                if (b == 1)
                {
                    if (potentialGap && currentBinaryGap > 0)
                    {
                        // Close Gap -> access if it is the longest
                        longestBinaryGap = (longestBinaryGap >= currentBinaryGap) ? longestBinaryGap : currentBinaryGap;
                        // restart gap counter
                        currentBinaryGap = 0;
                    }

                    potentialGap = true;
                }
                else
                {
                    if (potentialGap)
                    {
                        currentBinaryGap++;
                    }
                }
            }

            return longestBinaryGap;
        }

        public static int solutionBinaryGap2(int N)
        {
            int binaryGap = 0, currentBinaryGap = 0;

            if (N > 0)
            {
                string binary = Convert.ToString(N, 2);
                bool isInBinaryGap = false;
                for (var i = 0; i < binary.Length; i++) {
                    var isOne = binary[i] == '1';

                    if (isOne) {
                        isInBinaryGap = true;
                        binaryGap = (currentBinaryGap > binaryGap) ? currentBinaryGap : binaryGap;
                        currentBinaryGap = 0;
                    } else if (!isOne) {
                        currentBinaryGap++;
                    }
                }
            }

            return binaryGap;
        }
    }
}
