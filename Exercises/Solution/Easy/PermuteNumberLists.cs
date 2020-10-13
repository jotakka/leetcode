using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class PermuteNumberLists {
      public IList<IList<int>> Permute(int[] nums) {

         var results = new List<IList<int>>();
         if (nums == null || nums.Length == 0) {
            return results;
         }


         var first = new List<int>() { nums[0] };
         results.Add(first);

         for (int i = 1; i < nums.Length; i++) {

            var temp = new List<IList<int>>();

            foreach (var l in results) {
               var toAdd = new List<int>(l);
               toAdd.Add(nums[i]);
               temp.Add(toAdd);
               for (int j = 0; j < l.Count(); j++) {
                  toAdd = new List<int>(l);
                  toAdd.Insert(j, nums[i]);
                  temp.Add(toAdd);
               }
            }
            results = temp;
         }

         return results;
      }
   }
}
