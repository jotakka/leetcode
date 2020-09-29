using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class Intersection {
      public int[] intersection(int[] nums1, int[] nums2) {

         if (nums1 == null || nums1.Length == 0 || nums2.Length == 0 || nums2 == null) { return new int[0]; }

         var hashSet = new HashSet<int>();
         foreach (var a in nums1) {
            hashSet.Add(a);
         }


         var match = 0;
         foreach (var b in nums2) {

            if (hashSet.Contains(b)) {
               nums1[match] = b;
               match++;
               hashSet.Remove(b);
            }
         }
         var toReturn = new int[match];
         Array.Copy(nums1, toReturn, match);
         return toReturn;
      }
   }
}
