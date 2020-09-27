using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class Merge {
      public void merge(int[] nums1, int m, int[] nums2, int n) {


         if (n == 0) { return; }
         if (m == 0) {

            for (int i = 0; i < n; i++) {
               nums1[i] = nums2[i];
            }

         }
         var len = m + n;
         var mIdx = m - 1;
         var nIdx = n - 1;

         for (int i = len - 1; i >= 0; i--) {
            if (mIdx < 0) {
               nums1[i] = nums2[nIdx--];
               continue;
            }
            if (nIdx < 0) {
               nums1[i] = nums1[mIdx--];
               continue;
            }

            if (mIdx >= 0 && nums1[mIdx] > nums2[nIdx]) {
               nums1[i] = nums1[mIdx--];
            } else {
               nums1[i] = nums2[nIdx--];
            }
         }
      }
   }
}
