using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class AddBinary {
      public string addBinary(string a, string b) {

         if (a == "0") { return b; }
         if (b == "0") { return a; }

         var strBuildr = new StringBuilder();
         var carry = 0;
         for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--) {

            var sum = (i < 0 ? 0 : (a[i] - '0')) + (j < 0 ? 0 : (b[j] - '0')) + carry;
            carry = sum / 2;
            sum = sum % 2;
            strBuildr.Insert(0, $"{sum}");
         }

         strBuildr.Insert(0, carry > 0 ? "1" : "");

         return strBuildr.ToString();

      }
   }
}
