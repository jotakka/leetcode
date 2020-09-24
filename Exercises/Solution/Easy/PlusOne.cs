using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class PlusOne {
      public int[] plusOne(int[] digits) {
         var len = digits.Length;
         var carry = (digits[len - 1] + 1) / 10 != 0 ? 1 : 0;
         digits[len - 1] = (digits[len - 1] + 1) % 10;

         for (int i = len - 2; i >= 0 && carry != 0; i--) {
            carry = (digits[i] + 1) / 10 != 0 ? 1 : 0;
            digits[i] = (digits[i] + 1) % 10;
         }

         if (carry == 1) {
            var temp = new int[len + 1];
            temp[0] = 1;
            Array.Copy(digits, 0, temp, 1, len);
            digits = temp;
         }

         return digits;
      }
   }
}
