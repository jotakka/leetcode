using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class GroupAnagrams {
      public static IList<IList<string>> solution(string[] strs) {

         if (strs == null || strs.Length == 0) {
            return new string[0][];
         }
         var dict = new Dictionary<string, List<string>>();


         foreach (var str in strs) {
            var sortedStr = new string(str.OrderBy(s => s).ToArray());
            if (dict.ContainsKey(sortedStr)) {
               dict[sortedStr].Add(str);
            } else {
               dict.Add(sortedStr, new List<string>());
               dict[sortedStr].Add(str);
            }
         }


         var toReturn = new List<IList<string>>();

         foreach (var d in dict) {
            toReturn.Add(d.Value.ToArray());
         }


         return toReturn;
      }

   }
}
