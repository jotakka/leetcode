using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class LengthOfLongestSubstring {
      public static int solution(string s) {
         if (s == null) { return 0; }

         var len = s.Length;
         if (s.Length < 2) {
            return s.Length;
         }
         var charSet = new HashSet<char>();
         var begin = 0;
         var end = 0;
         var maxLenGlob = 0;
         var maxLenLoc = 0;
         while (begin < len) {

            if (!charSet.Contains(s[begin])) {
               charSet.Add(s[begin]);
               begin++;
               maxLenLoc++;
            } else {
               charSet.Remove(s[end]);
               maxLenLoc--;
               end++;
            }

            maxLenGlob = Math.Max(maxLenGlob, maxLenLoc);

         }
         return maxLenGlob;
      }
   }
}
