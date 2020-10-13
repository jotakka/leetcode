using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class PivotIndex {
      public int pivotIndex(int[] nums) {
         if (nums == null) {
            return -1;
         }
         if (nums.Length == 0) {
            return -1;
         }
         if (nums.Length < 2) {
            return 0;
         }

         var len = nums.Length;
         var lrSum = new int[len];
         var rlSum = new int[len];
         lrSum[0] = nums[0];
         rlSum[len - 1] = nums[len - 1];

         for (int i = 1; i < len - 1; i++) {
            lrSum[i] = lrSum[i - 1] + nums[i];
            rlSum[len - i - 1] = rlSum[(len - 1 - i) + 1] + nums[len - 1 - i];
         }

         lrSum[len - 1] = lrSum[len - 2] + nums[len - 1];
         rlSum[0] = rlSum[1] + nums[0];

         Array.ForEach(lrSum, Console.WriteLine);
         Array.ForEach(rlSum, Console.WriteLine);

         if (rlSum[1] == 0) {
            return 0;
         }


         for (int i = 1; i < len - 1; i++) {
            if (lrSum[i - 1] == rlSum[i + 1]) {
               return i;
            }
         }



         if (lrSum[len - 2] == 0) {
            return len - 1;
         }

         return -1;
      }
   }
}
