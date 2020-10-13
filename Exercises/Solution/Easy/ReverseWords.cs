using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class ReverseWords {
      public string reverseWords(string s) {
         var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
         Array.Reverse(words);
         return string.Join(" ", words);
      }
   }
}
