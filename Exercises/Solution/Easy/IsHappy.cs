using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class IsHappy {
      public bool isHappy(int n) {
         var visited = new HashSet<int>();

         var cn = n;
         visited.Add(cn);

         while (cn != 1) {
            var str = $"{cn}";
            var sum = 0;
            foreach (var c in str) {
               var num = c - '0';
               sum += num * num;
            }
            cn = sum;
            if (visited.Contains(cn)) {
               return false;
            }

            visited.Add(cn);
         }
         return true;
      }
   }
}
