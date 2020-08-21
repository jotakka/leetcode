using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class TopKFrequent {

      public static IList<string> solution(string[] words, int k) {

         if (words == null || words.Length == 0) { return new List<string>(); }
         var dict = new Dictionary<string, int>();

         for (int i = 0; i < words.Length; i++) {
            if (dict.ContainsKey(words[i])) {
               dict[words[i]]++;
            } else {
               dict.Add(words[i], 1);
            }
         }

         var dictAsArray = dict.ToArray();
         Array.Sort(
            dictAsArray,
            (p1, p2) => {
               if (p1.Value == p2.Value) {
                  return string.Compare(p1.Key, p2.Key);
               } else {
                  return p2.Value - p1.Value;
               }
            }
            );


         return dictAsArray.Take(k).ToList().ConvertAll(
            d => d.Key
            );
      }
   }
}
