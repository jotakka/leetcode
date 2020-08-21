using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class SubarraySum {

      public static  int solution(int[] nums, int k) {

         var len = nums.Length;
         var prefixSumArr = new int[len + 1];
         prefixSumArr[0] = nums.First();
         for (int i = 1; i < len + 1; i++) {
            prefixSumArr[i] = prefixSumArr[i - 1] + nums[i - 1];
         }

         var count = 0;
         for (int i = 0; i < len; i++) {
            for (int j = i + 1; j < len + 1; j++) {
               if (prefixSumArr[j] - prefixSumArr[i] == k) {
                  count++;
               }
            }
         }


         return count;

      }
   }
}
