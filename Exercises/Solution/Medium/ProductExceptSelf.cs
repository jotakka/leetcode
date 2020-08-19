using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class ProductExceptSelf {

      public static int[] solution(int[] nums) {

         var mult = 1;
         var countZero = 0;
         foreach (var num in nums) {
            mult *= num == 0 ? 1 : num;
            countZero += num == 0 ? 1 : 0;

         }

         var toReturn = new int[nums.Length];

         for (int i = 0; i < nums.Length; i++) {
            if (countZero > 0) {

               toReturn[i] = nums[i] == 0 ?
                  mult * (countZero > 1 ? 0 : 1) : 0;
            } else {
               toReturn[i] = mult / nums[i];
            }
         }


         return toReturn;
      }

   }
}
