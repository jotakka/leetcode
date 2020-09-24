using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   public class FindMaxConsecutiveOnes {

      public int findMaxConsecutiveOnes(int[] nums) {
         if (nums is null || nums.Length == 0) { return 0; }

         var length = nums.Length;
         var cnt = 0;
         var max = 0;

         for (int i = 0; i < length; i++) {
            cnt = nums[i] == 1 ? cnt + 1 : 0;
            max = Math.Max(cnt, max);
         }
         return max;
      }

   }
}
