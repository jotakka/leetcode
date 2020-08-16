using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Top100InterviewQuestions.Easy {
   class MajorityElement {

      public static int majorityElement(int[] nums) {


         //var dictCounter = new Dictionary<int, int>();
         var topElement = -1;

         var stackSize = 0;
         for (int i = 0; i < nums.Length; i++) {

            if (stackSize > 0 && nums[i] != topElement) {
               stackSize--;
               continue;
            }
            if (stackSize == 0) {
               topElement = nums[i];
            }
            stackSize++;

         }

         return topElement;
      }

   }
}
