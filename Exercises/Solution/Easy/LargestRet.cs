using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class LargestRet {
      public int LargestRectangleArea(int[] heights) {

         return largestRectangleArea(heights);
      }

      public int largestRectangleArea(int[] heights) {

         if (heights == null || heights.Length == 0) { return 0; }

         var len = heights.Length;
         var min = heights.Min();
         var minIdx = Array.IndexOf(heights, min);

         var l = new int[minIdx];
         var r = new int[len - minIdx - 1];

         Array.Copy(heights, l, minIdx);
         Array.Copy(heights, minIdx + 1, r, 0, len - minIdx - 1);


         var maxArea = min * len;

         var masAreaL = largestRectangleArea(l);
         var maxAreaR = largestRectangleArea(r);

         return Math.Max(Math.Max(maxAreaR, maxArea), masAreaL);

      }
   }
}
