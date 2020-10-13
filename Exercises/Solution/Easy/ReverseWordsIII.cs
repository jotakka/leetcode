using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class ReverseWordsIII {
      public string reverseWords(string s) {
         var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

         for (int i = 0; i < words.Length; i++) {

            words[i] = new string(words[i].Reverse().ToArray());
         }

         return string.Join(" ", words);
      }
   }
}
