using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class MissingNumber {

      public static int missingNumber(int[] nums) {
         var len = nums.Length;
         var sum = (len * (len + 1)) / 2;
         var sumArr = 0;
         foreach (var item in nums) {
            sumArr += item;
         }
         return sum - sumArr;
      }
   }
}

