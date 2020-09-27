using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class ReplaceElements {

      public int[] replaceElements(int[] arr) {
         if (arr == null || arr.Length <= 0) {
            return new int[0];
         }
         var length = arr.Length;
         var max = arr[length - 1];
         arr[length - 1] = -1;
         for (int i = length - 2; i >= 0; i--) {

            var aux = arr[i];
            arr[i] = max;
            max = Math.Max(max, aux);

         }
         return arr;
      }
   }
}