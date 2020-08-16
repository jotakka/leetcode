using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Top100InterviewQuestions.Easy {
   class FizzBuzz {
      public static IList<string> fizzBuzz(int n) {

         var toReturn = new List<string>();
         for (int i = 1; i <= n; i++) {

            if (i % 5 != 0 && i % 3 != 0) {
               toReturn.Add($"{i}");
            } else {
               var str = (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "");
               toReturn.Add(str);

            }

         }
         return toReturn;
      }
   }
}
