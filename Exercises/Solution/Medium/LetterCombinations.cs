using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class LetterCombinations {
      private static readonly Dictionary<char, string> buttons =
         new Dictionary<char, string>() {
            { '2',"abc"},{ '3',"def"},{ '4',"ghi"},
            { '5',"jkl"},{ '6',"mno"},{ '7',"pqrs"},
            { '8',"tuv"},{ '9',"wxyz"}
         };

      public static IList<string> solution(string digits) {

         if (string.IsNullOrEmpty(digits)) {
            return new List<string>();
         }


         var toReturn = new List<string>();

         var first = buttons[digits[0]].ToList().ConvertAll(c => $"{c}");
         toReturn.AddRange(first);

         for (int i = 1; i < digits.Length; i++) {
            var tempList = new List<string>();
            foreach (var item in toReturn) {
               var buttonStr = buttons[digits[i]];
               for (int j = 0; j < buttonStr.Length; j++) {
                  tempList.Add($"{item}{buttonStr[j]}");
               }
            }
            toReturn = tempList;
         }

         return toReturn;
      }
   }
}
