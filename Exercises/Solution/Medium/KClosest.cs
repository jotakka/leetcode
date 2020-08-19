using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class KClosest {
      public static int[][] solution(int[][] points, int K) {
         if (points == null) { return new int[0][]; }
         var length = points.Length;
         if (length <= K) { return points; }
         Array.Sort(points, (p1, p2) => (p1[0] * p1[0] + p1[1] * p1[1]).CompareTo(p2[0] * p2[0] + p2[1] * p2[1]));
         Array.Resize(ref points, K);
         return points;
      }
   }
}
