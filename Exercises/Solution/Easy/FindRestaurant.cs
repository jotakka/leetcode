using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class FindRestaurant {
      public string[] findRestaurant(string[] list1, string[] list2) {

         if (list2 == null || list2.Length == 0) { return new string[0]; }
         if (list1 == null || list1.Length == 0) { return new string[0]; }


         var dict = new Dictionary<string, int>();
         var toRet = new List<string>();
         var min = int.MaxValue;

         for (int i = 0; i < list1.Length; i++) {

            if (!dict.ContainsKey(list1[i])) {
               dict.Add(list1[i], -i);
            }
         }


         for (int i = 0; i < list2.Length; i++) {

            if (dict.ContainsKey(list2[i])) {
               var sum = i - dict[list2[i]];
               if (sum < min) {
                  toRet.Clear();
                  toRet.Add(list2[i]);
                  min = sum;
               } else if (sum == min) {
                  toRet.Add(list2[i]);
               }
            }
         }
         return toRet.ToArray();
      }
   }
}
