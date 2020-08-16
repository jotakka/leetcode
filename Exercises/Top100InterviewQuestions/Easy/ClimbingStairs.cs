using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Top100InterviewQuestions.Easy {
   class ClimbingStairs {
      public int ClimbStairs(int n) {
         var sumsWays = new int[2];

         sumsWays[0] = 1;
         sumsWays[1] = 2;

         if (n == 1) { return 1; }
         if (n == 2) { return 2; }

         for (int i = 2; i < n; i++) {
            sumsWays[i % 2] = sumsWays[(i - 1) % 2] + sumsWays[(i - 2) % 2];
         }


         return sumsWays.Max(); ;
      }
   }
}
