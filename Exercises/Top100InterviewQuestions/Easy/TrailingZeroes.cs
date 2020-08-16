using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace leetcode.Exercises.Top100InterviewQuestions.Easy {
   class TrailingZeroes {

      //[100/5] + [100/5²] + [100/5³] = 20 + 4 + 0 = 24


      public  int TrailingZeroesUsingTheorem(int n) {


         var diviser = 5L;
         long resultDiv;
         var sum = 0L;
         do {

            resultDiv = n / diviser;
            diviser *= 5L;
            sum += resultDiv;

         } while (resultDiv > 0);

         return (int)sum;
      }

      public static int trailingZeroes(int n) {

         if (n < 2) { return 0; }

         var bigIntegerValue = new BigInteger(1);

         for (int i = n; i >= 1; i--) {

            bigIntegerValue = BigInteger.Multiply(i, bigIntegerValue);
         }

         var result = $"{bigIntegerValue}";
         var count = 0;
         for (int i = result.Length - 1; i >= 0; i--) {
            if (result[i] == '0') {
               count++;
               if (result[i - 1] != '0') { return count; }

            } else {
               return count;
            }
         }

         return count; 

      }
   }
}
