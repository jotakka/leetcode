using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class HammingWeight {

      public int hammingWeight(uint n) {
         var count = 0;

         do {

            var result = n & (~(n + 1));
            if (result != 0) { count++; }

            n -= result;


         } while (n != 0);


         return count;

      }

   }
}
