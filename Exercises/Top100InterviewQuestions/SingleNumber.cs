using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Top100InterviewQuestions {
   class SingleNumber {
      public static int singleNumber(int[] nums) {

         var result = 0;

         foreach (var item in nums) {
            result ^= item;
         }
         return result;
      }
   }
}
