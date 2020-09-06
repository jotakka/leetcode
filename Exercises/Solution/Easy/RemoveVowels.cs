using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   public class RemoveVowels {
      public static string removeVowels(string S) {
         HashSet<char> set = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
         var strBuilder = new StringBuilder();
         foreach (var c in S) {
            if (!set.Contains(c)) {
               strBuilder.Append(c);
            }
         }
         return strBuilder.ToString();
      }

   }
}
