using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   public class Intersect {

      public int[] intersect(int[] nums1, int[] nums2) {
         if (nums1 == null || nums2 == null) { return new int[0]; }
         if (nums1.Length == 0 || nums2.Length == 0) { return new int[0]; }


         var dict = new Dictionary<int, int>();
         var list = new List<int>();

         foreach (var n in nums1) {
            if (dict.ContainsKey(n)) {
               dict[n]++;
            } else {
               dict.Add(n, 1);
            }
         }


         foreach (var n in nums2) {
            if (dict.ContainsKey(n)) {
               list.Add(n);
               dict[n]--;
               if (dict[n] == 0) { dict.Remove(n); }
            }
         }

         return list.ToArray();
      }
   }
}
