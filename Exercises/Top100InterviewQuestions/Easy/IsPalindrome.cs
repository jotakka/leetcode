using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Top100InterviewQuestions.Easy {
   class IsPalindrome {

      public static bool isPalindrome(string s) {

         var filtered = (new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray())).ToLower();
         if (filtered.Length < 2) return true;

         var len = filtered.Length;

         for (int i = 0; i < len / 2; i++) {
            if (filtered[i] != filtered[len - i - 1]) {
               return false;
            }
         }
         return true;
      }
   }
}
