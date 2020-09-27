using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class FirstUniqChar {
      public int firstUniqChar(string s) {
         if (string.IsNullOrEmpty(s)) { return -1; }
         if (s.Length == 1) { return 0; }
         var unqDict = new Dictionary<char, int>();
         var allSet = new HashSet<char>();
         for (int i = 0; i < s.Length; i++) {
            if (allSet.Contains(s[i])) {
               if (unqDict.ContainsKey(s[i])) {
                  unqDict.Remove(s[i]);
               }
            } else {
               unqDict.Add(s[i], i);
               allSet.Add(s[i]);
            }
         }

         if (!unqDict.Any()) {
            return -1;
         } else {
            return unqDict.Min(c => c.Value);
         }
      }
   }
}
