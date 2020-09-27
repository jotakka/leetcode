using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class ValidMountainArray {
      public bool validMountainArray(int[] A) {

         if (A is null || A.Length <= 1) { return false; }

         if (A[1] - A[0] <= 0) return false;
         var up = true;

         for (int i = 0; i < A.Length - 1; i++) {


            if (A[i] == A[i + 1]) return false;

            if (up && A[i + 1] - A[i] < 0) {
               up = false;
            } else if (up == false && A[i + 1] - A[i] > 0) {
               return false;
            }
         }
         return true && up == false;
      }
   }
}
