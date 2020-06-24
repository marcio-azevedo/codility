using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Katas.Lessons
{
    public class Numbrs
    {
        public static int BudgetShopping(int n, int[] bundleQuantities, int[] bundleCosts)
        {
            int totalNotebooks = 0;
            if (n != 0) {
                totalNotebooks = BudgetShopping(n, bundleQuantities, bundleCosts, bundleQuantities.Length-1, bundleQuantities.Length-1);
            }

            return totalNotebooks;
        }

        public static int BudgetShopping(int remainingBudget, int[] bundleQuantities, int[] bundleCosts, int currentIndex, int startingIndex)
        {
            int totalNotebooks = 0;
            int nextIndex = currentIndex - 1;

            if (currentIndex < 0 || remainingBudget == 0)
                totalNotebooks = 0;
            else {
                if (bundleCosts[currentIndex] > remainingBudget)
                    totalNotebooks = BudgetShopping(remainingBudget, bundleQuantities, bundleCosts, nextIndex, startingIndex);
                else {
                    var a = bundleQuantities[currentIndex] + BudgetShopping(remainingBudget - bundleCosts[currentIndex], bundleQuantities, bundleCosts, startingIndex, startingIndex);
                    var b = BudgetShopping(remainingBudget, bundleQuantities, bundleCosts, nextIndex, startingIndex);
                    
                    totalNotebooks = (a > b) ? a : b;
                }
            }

            return totalNotebooks;
        }

        public static List<int> OddNumbers(int l, int r)
        {
            var result = new List<int>();
            var firstOddNumber = (l % 2 == 0) ? l+1 : l;

            result.Add(firstOddNumber);

            var currentNumber = firstOddNumber + 2;
            while (currentNumber <= r) {
                result.Add(currentNumber);
                currentNumber = currentNumber + 2;
            }

            return result;
        }
    }
}