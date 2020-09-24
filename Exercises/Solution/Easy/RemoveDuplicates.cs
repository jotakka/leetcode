using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   public static class RemoveDuplicates {

      public static int removeDuplicates(int[] nums) {

         if (nums == null || nums.Length == 0) {
            return 0;
         }

         if (nums.Length == 1) {
            return 1;
         }

         var pointer = 1;

         for (int i = 1; i < nums.Length; i++) {

            if (nums[i] != nums[i - 1]) {
               nums[pointer++] = nums[i];

            }
         }
         return pointer;
      }

   }
}
