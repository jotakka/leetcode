using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class IsArmstrong {
      public bool isArmstrong(int N) {

         var s = $"{N}";
         var sum = 0;
         var k = s.Length;
         foreach (var c in s) {

            var n = c - '0';

            sum += (int)Math.Pow(n, k);

         }
         return sum == N;
      }
   }
}
