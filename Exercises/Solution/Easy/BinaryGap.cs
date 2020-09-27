using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class BinaryGap {
      public int binaryGap(int N) {

         var max = 0;
         var count = 0;
         var betweenOne = false;
         var hasOnes = false;
         while (N != 0) {


            if (betweenOne == false && (N & 0x01) == 1) {
               betweenOne = true;
            } else if (betweenOne && (N & 0x01) == 1) {
               count++;
               max = Math.Max(count, max);
               count = 0;
               hasOnes = true;
            } else if (betweenOne && (N & 0x01) == 0) {
               count++;
            }
            N >>= 1;
         }

         return hasOnes ? max : 0;
      }
   }
}
