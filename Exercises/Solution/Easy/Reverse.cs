using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class Reverse {
      public int reverse(int x) {
         try {
            var s = $"{Math.Abs(x)}";
            var signal = Math.Sign(x);
            s = new string(s.Reverse().ToArray());
            int toReturn;
            var result = int.TryParse(s, out toReturn);

            return result ? toReturn * signal : 0;

         } catch (Exception) {
            return 0;
         }
      }
   }
}
