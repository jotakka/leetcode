using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   public class Solution {
      public int MaximalSquare(char[][] matrix) {
         var height = matrix.Length;
         var width = matrix[0].Length;
         var max = int.MinValue;

         var maxSqrs = new int[height, width];
         for (int i = 0; i < height; i++) {
            maxSqrs[i, 0] = matrix[i][0] - '0';
            max = Math.Max(maxSqrs[i, 0], max);
         }
         for (int i = 0; i < width; i++) {
            maxSqrs[0, i] = matrix[0][i] - '0';
            max = Math.Max(maxSqrs[0, i], max);

         }




         for (int i = 1; i < height; i++) {
            for (int j = 1; j < width; j++) {


               if (matrix[i][j] == '1') {

                  maxSqrs[i, j] =
                  1 +
               Math.Min(
                  Math.Min(maxSqrs[i - 1, j - 0] , maxSqrs[i - 0, j - 1] ),
                  maxSqrs[i - 1, j - 1]
                  );
               }

               max = Math.Max(maxSqrs[i, j], max);

            }
         }

         return max * max;
      }
   }
}

