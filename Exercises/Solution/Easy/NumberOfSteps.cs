using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class NumberOfSteps {
      public static int numberOfSteps(int num) {
         var n = num;

         var count = 0;
         while (n > 0) {

            if (n % 2 == 1) {
               n--;
            } else {
               n /= 2;
            }
            count++;
         }

         return count;

      }
   }
}
