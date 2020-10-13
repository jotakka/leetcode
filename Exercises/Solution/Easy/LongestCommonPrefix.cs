using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   public class LongestCommonPrefix {
      public string longestCommonPrefix(string[] strs) {

         if (strs == null || strs.Length == 0) {
            return "";
         }
         if (strs.Length == 1) {
            return strs.First();
         }

         string maxPrefix = "";
         for (int i = 1; i < strs.Length; i++) {

            if (i == 1) {
               maxPrefix = strs[i - 1];
            }
            var curr = strs[i];
            var strBuilder = new StringBuilder();
            for (int j = 0; j < Math.Min(curr.Length, maxPrefix.Length); j++) {
               if (curr[j] == maxPrefix[j]) {
                  strBuilder.Append(curr[j]);
               } else {
                  break;
               }
            }
            maxPrefix = strBuilder.ToString();
            if (maxPrefix.Length == 0) {
               return "";
            }
         }
         return maxPrefix;
      }
   }
}
