using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class RemoveElement {
      public int removeElement(int[] nums, int val) {

         if (nums.Length == 0 || nums == null) {
            return nums.Length;
         }

         var last = nums.Length - 1;
         var start = -1;

         while (last >= start) {
            start++;

            if (start < nums.Length && nums[start] == val) {
               while (last >= 0 && nums[last] == val) {
                  last--;

               }
               if (last < 0) { return 0; }
               nums[start] = nums[last];
               last--;
            }
         }
         return start;
      }
   }
}
