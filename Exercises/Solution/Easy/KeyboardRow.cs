using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {


   class KeyboardRow {
      List<string> kbRows =
        new List<string> {
      "qwertyuiop",
      "asdfghjkl",
      "zxcvbnm"
      };


      public string[] FindWords(string[] words) {
         if (words.Length == 0) return new string[0];
         var toReturn = new List<string>();
         foreach (var word in words) {
            var contains = false;
            foreach (var row in kbRows) {
               contains |= !word.Any(c => !row.Contains(c));
               Console.WriteLine(!word.Any(c => !row.Contains(c)));
            }
            if (contains) {
               toReturn.Add(word);
            }
            
         }
         return toReturn.ToArray();
      }


   }
}
