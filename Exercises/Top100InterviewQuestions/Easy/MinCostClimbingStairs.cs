using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Top100InterviewQuestions.Easy {
   class MinCostClimbingStairs {

      public static int minCostClimbingStairs(int[] cost) {
         var costRegister = new int[2];
         if (cost.Length == 2) {
            return Math.Min(cost[0], cost[1]);
         }


         costRegister[0] = cost[0];
         costRegister[1] = cost[1];

         for (int i = 2; i < cost.Length; i++) {
            costRegister[i % 2] = cost[i] + Math.Min(costRegister[(i - 1) % 2], costRegister[(i - 2) % 2]);
         }

         return costRegister.Min();
      }

   }
}
