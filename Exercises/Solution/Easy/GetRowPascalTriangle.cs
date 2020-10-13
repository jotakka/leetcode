using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class GetRowPascalTriangle {
      public IList<int> GetRow(int rowIndex) {
         if (rowIndex == 0) return new int[] { 1 };
         var rows = rowIndex + 1;
         var matx = new int[rows][];

         matx[0] = new int[1];
         matx[1] = new int[2];

         matx[0][0] = 1;
         matx[1][0] = matx[1][1] = 1;

         if (rowIndex < 2) {
            return matx[rowIndex];
         }

         for (int i = 2; i < rows; i++) {
            matx[i] = new int[i + 1];
            matx[i][0] = 1;
            matx[i][i] = 1;
            for (int j = 1; j < i; j++) {
               matx[i][j] = matx[i - 1][j - 1] + matx[i - 1][j];
            }
         }
         return matx[rowIndex];
      }
   }
}
