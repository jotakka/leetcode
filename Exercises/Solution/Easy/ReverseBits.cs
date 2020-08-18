using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class ReverseBits {

      public static uint reverseBits(uint n) {

         var nCopy = n;
         var output = 0u;
         var mask = 0x01u;
         for (int i = 0; i < sizeof(uint) * 8; i++) {
            output <<= 1;
            output |= (mask & nCopy);
            nCopy >>= 1;
         }
         return output;
      }
   }
}
