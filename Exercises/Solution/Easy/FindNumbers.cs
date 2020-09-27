using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class FindNumbers {
      public int findNumbers(int[] nums) {
         if (nums == null || nums.Length == 0) return 0;
         var cnt = 0;
         foreach (var n in nums) {
            if (n.ToString().Length % 2 == 0) {
               cnt++;
            }
         }
         return cnt;
      }
   }
}
