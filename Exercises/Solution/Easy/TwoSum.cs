using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class TwoSum {

      public static int[] twoSum(int[] nums, int target) {
         var set = new Dictionary<int, int>();

         for (int i = 0; i < nums.Length; i++) {

            var rest = target - nums[i];
            if (set.ContainsKey(rest)) {
               return new int[] { set[rest], i };
            }
            if (!set.ContainsKey(nums[i])) {
               set.Add(nums[i], i);

            }
         }
         return new int[0];
      }
   }
}
