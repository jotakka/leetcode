using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class Triangle {
      public static int MinimumTotal(IList<IList<int>> triangle) {

         if (triangle.Count == 0) return 0;
         if (triangle.Count == 1) {
            if (triangle.First().Count == 0) return 0;
            return triangle.First().First();
         };

         var height = triangle.Count();
         var maxLength = triangle.Last().Count();
         var minSums = new int[height, maxLength];
         int min = minSums[0, 0];
         minSums[0, 0] = triangle.First().First();
         for (int h = 1; h < height; h++) {

            var currentFloor = triangle.ElementAt(h);
            var floorLengtht = currentFloor.Count();
            min = int.MaxValue;
            for (int l = 0; l < floorLengtht; l++) {
               minSums[h, l] =
                  currentFloor.ElementAt(l) +
                  Math.Min(
                  minSums[h - 1, Math.Max(l - 1, 0)],
                     minSums[h - 1, Math.Min(l, floorLengtht - 2)]);

               min = Math.Min(min, minSums[h, l]);
            }
         }

         return min;
      }
   }
}
