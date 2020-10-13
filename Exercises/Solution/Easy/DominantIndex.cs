using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class DominantIndex {
      public int dominantIndex(int[] nums) {
         if (nums == null || nums.Length == 0) {
            return -1;
         }
         if (nums.Length == 1) {
            return 0;
         }

         if (nums.Length == 2) {
            var mx = nums.Max();
            var mn = nums.Min();
            if (mx >= mn * 2) {
               return Array.IndexOf(nums, mx);

            }
         }


         var len = nums.Length;
         var lastMax = 0;
         var max = 0;
         var maxIdx = -1;
         for (int i = 0; i < len; i++) {
            if (nums[i] > max) {
               lastMax = max;
               max = nums[i];
               maxIdx = i;
            } else if (nums[i] > lastMax) {
               lastMax = nums[i];
            }

         }


         if (max == 0) { return 0; }

         if (max >= lastMax * 2) {
            return maxIdx;
         }

         return -1;
      }
   }
}

