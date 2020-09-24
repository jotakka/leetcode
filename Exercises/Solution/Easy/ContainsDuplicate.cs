using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   public class ContainsDuplicate {


      public int[] PlusOne(int[] digits) {
         var len = digits.Length;
         var carry = (digits[len-1] + 1) / 10 != 0 ? 1 : 0;
         digits[len-1] = (digits[len-1] + 1)%10;

         for (int i = len-2; i >= 0 && carry!=0; i++) {
            carry = (digits[i] + 1) / 10 != 0 ? 1 : 0;
            digits[i] = (digits[i] + 1) % 10;
         }

         return digits;
      }
      public static bool containsDuplicate(int[] nums) {
         var toSet = new HashSet<int>(nums);

         return toSet.Count() != nums.Length;
      }

   }
}
