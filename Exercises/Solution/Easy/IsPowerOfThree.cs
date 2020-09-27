using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class IsPowerOfThree {
      public bool isPowerOfThree(int n) {

         if (n == 0) return false;

         var log = Math.Log(n) / Math.Log(3);



         return Math.Pow(3, Math.Round(log)) == n;

      }

   }
}
