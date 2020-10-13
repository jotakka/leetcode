using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class SortArray {
      public int[] sortArray(int[] nums) {
         if (nums == null || nums.Length == 0) { return new int[0]; }
         if (nums.Length == 1) {
            return nums;
         }
         if (nums.Length == 2) {
            var l = nums[0];
            var r = nums[1];
            nums[0] = Math.Min(l, r);
            nums[1] = Math.Max(l, r);
         }


         var lenL = nums.Length / 2;
         var lenR = nums.Length - lenL;
         var left = new int[lenL];
         var right = new int[lenR];

         Array.Copy(nums, left, lenL);
         Array.Copy(nums, lenL, right, 0, lenR);

         var orderedLeft = SortArray(left);
         var orderedRight = SortArray(right);

         merge(orderedLeft, orderedRight, ref nums);

         return nums;
      }


      private void merge(int[] left, int[] right, ref int[] outArr) {
         var leftIdx = 0;
         var rightIdx = 0;
         for (int i = 0; i < outArr.Length; i++) {

            if (left.Length <= leftIdx) {
               outArr[i] = right[rightIdx++];
            } else if (right.Length <= rightIdx) {
               outArr[i] = left[leftIdx++];
            } else
              if (left[leftIdx] < right[rightIdx]) {
               outArr[i] = left[leftIdx++];
            } else {
               outArr[i] = right[rightIdx++];
            }
         }
      }
   }
}
