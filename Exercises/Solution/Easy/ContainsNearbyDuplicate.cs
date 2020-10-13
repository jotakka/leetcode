using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {

   class ContainsNearbyDuplicate {
      public bool containsNearbyDuplicate(int[] nums, int k) {
         if (nums == null || nums.Length == 0) { return false; }
         if (k == 0) { return false; }
         var dict = new Dictionary<int, int>();

         var length = nums.Length;
         for (int i = 0; i < length; i++) {
            if (dict.ContainsKey(nums[i])) {

               if (i - dict[nums[i]] <= k) {
                  return true;
               }
               dict[nums[i]] = i;
            } else {
               dict.Add(nums[i], i);
            }
         }
         return false;
      }

   }
}
