using System;
using System.Collections.Generic;

namespace Codility.Katas.Lessons
{
    // Sorting - https://app.codility.com/programmers/lessons/6-sorting/
    public class Sorting
    {
        public static int Distinct(int[] A) {
            int n = A.Length;
            int distinct = 0;
            int lastNumber = 0;

            if (n > 0) {
                Array.Sort(A);
                // for (int i = 0; i < n; i++)
                // {
                //     for (int j = i+1; j < n; j++)
                //     {
                //         int a = A[i];
                //         int b = A[j];
                //         if (b < a) {
                //             A[i] = b;
                //             A[j] = a;
                //         }
                //     }
                // }

                lastNumber = A[0];
                distinct++;
                for (int i = 1; i < n; i++)
                {
                    int v = A[i];
                    distinct += (lastNumber != v) ? 1 : 0;
                    lastNumber = A[i];
                }
            }

            return distinct;
        }
    
        public static int MaxProductOfThree(int[] A) {
            int n = A.Length;

            Array.Sort(A);
            var nNumber = A[n-1];
            var n1Number = A[n-2];
            var n2Number = A[n-3];
            
            int result = nNumber * n1Number * n2Number;

            if (n > 3) {
                var fstNumber = A[0];
                var sndNumber = A[1];
                var trdNumber = A[2];

                result = (result < (fstNumber * sndNumber * trdNumber)) ? (fstNumber * sndNumber * trdNumber) : result;
                result = (result < (fstNumber * sndNumber * nNumber)) ? (fstNumber * sndNumber * nNumber) : result;
                result = (result < (fstNumber * n1Number * nNumber)) ? (fstNumber * n1Number * nNumber) : result;
            }

            return result;
        }

        public static int Triangle(int[] A) {
            int n = A.Length;
            int hasTriangular = 0;

            if (n >= 3) {
                Array.Sort(A);

                for (int p = 0; p < n-2; p++)
                {
                    int q = p + 1;
                    int r = p + 2;
                    long pValue = A[p];
                    long qValue = A[q];
                    long rValue = A[r];

                    if ((pValue + qValue > rValue) &&
                        (qValue + rValue > pValue) &&
                        (pValue + rValue > qValue)) {
                        hasTriangular = 1;
                        break;
                    }
                }
            }

            return hasTriangular;
        }

        public static void MergeSort(int[] array) {

        }
    }
}