using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class ConvertToBaseMinus2 {
      public string BaseNeg2(int n) {
         if (n == -1) { return "11"; };
         var base2 = -2;
         var next = n;
         var strBuilder = new StringBuilder();
         do {

            var div = next / base2;

            if (div <= 0) {

               strBuilder.Insert(0, Math.Abs(next) % Math.Abs(base2));
               next = div;
            } else {
               if (Math.Abs(next) % Math.Abs(base2) != 0) {
                  next = div + 1;

                  strBuilder.Insert(0, 1);
               } else {
                  next = div;
                  strBuilder.Insert(0, 0);
               }
            }

            if (div == -1) {
               strBuilder.Insert(0, 11);
               next = 0;
            }
            Console.WriteLine(next);
         } while (next != 0);

         return strBuilder.ToString();
      }
   }
}
