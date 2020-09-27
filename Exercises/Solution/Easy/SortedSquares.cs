using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class SortedSquares {
      public int[] sortedSquares(int[] A) {

         for (int i = 0; i < A.Length; i++) {
            A[i] = A[i] * A[i];
         }

         Array.Sort(A);

         return A;
      }
   }
}
