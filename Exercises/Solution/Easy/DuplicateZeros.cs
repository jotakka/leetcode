using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class DuplicateZeros {
      public void duplicateZeros(int[] arr) {

         for (int i = 0; i < arr.Length - 1; i++) {
            if (arr[i] == 0) {
               if (i == arr.Length - 2) {
                  arr[arr.Length - 1] = 0;
               }
               Array.Copy(arr, i + 1, arr, i + 2, Math.Max(0, arr.Length - i - 2));
               arr[Math.Min(i + 1, arr.Length)] = 0;
               i += 1;
            }
         }
      }
   }
}
