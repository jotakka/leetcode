using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class GenerateParenthesis {

      public static IList<string> solution(int n) {

         if (n == 0) return new List<string>() { "" };
         const string toInsert = "()";
         var validSet = new HashSet<string>();

         validSet.Add("()");

         for (int i = 1; i < n; i++) {
            var currentHashSet = new HashSet<string>();
            foreach (var valid in validSet) {
               var len = valid.Length;
               for (int j = 0; j < len; j++) {
                  var strBuilder = new StringBuilder(valid);
                  strBuilder.Insert(j, toInsert);
                  currentHashSet.Add(strBuilder.ToString());
               }
            }
            validSet = currentHashSet;
         }

         return validSet.ToArray();
      }
   }
}
