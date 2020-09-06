using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class Shufle {
      public static int[] Shuffle(int[] nums, int n) {
         if (n == 0) {
            return new int[0];
         }

         var toReturn = new int[2 * n];

         for (int i = 0; i < n; i++) {
            toReturn[2 * i] = nums[i];
            toReturn[2 * i + 1] = nums[n + i];
         }
         return toReturn;
      }
   }
}
