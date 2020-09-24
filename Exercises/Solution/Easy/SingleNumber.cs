using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   public class SingleNumber {
      public int singleNumber(int[] nums) {

         var result = 0;

         foreach (var item in nums) {
            result ^= item;
         }
         return result;
      }

   }
}
