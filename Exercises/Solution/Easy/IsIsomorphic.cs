using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class IsIsomorphic {
      public bool isIsomorphic(string s, string t) {
         var dict = new Dictionary<char, char>();
         var dict2 = new Dictionary<char, char>();

         if (string.IsNullOrEmpty(s)) { return true; }

         for (int i = 0; i < s.Length; i++) {

            if (dict.ContainsKey(s[i])) {
               if (dict[s[i]] != t[i]) {
                  return false;
               }
            } else {
               dict.Add(s[i], t[i]);
            }

            if (dict2.ContainsKey(t[i])) {
               if (dict2[t[i]] != s[i]) {
                  return false;
               }
            } else {
               dict2.Add(t[i], s[i]);
            }
         }
         return true;
      }
   }
}
