using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   class Permutations {
      public static IList<IList<int>> Permute(int[] list) {
         var permutations = new List<int[]>();

         for (int j = 0; j < list.Length; j++) {
            var item = list[j];

            if (j == 0) {
               permutations.Add(new int[] { item });
               continue;
            }

            var newPerms = new List<int[]>();
            foreach (var permutation in permutations) {

               for (int i = 0; i <= permutation.Length; i++) {

                  var newPerm = new int[permutation.Length + 1];

                  newPerm[i] = item;
                  if (permutation.Length > 0) {
                     Array.Copy(permutation, 0, newPerm, 0, i);
                     if (i < permutation.Length)
                        Array.Copy(permutation, i, newPerm, i + 1, permutation.Length - i);
                  }
                  newPerms.Add(newPerm);
               }

            }
            permutations = newPerms;
         }

         var toReturn = permutations.ConvertAll(
            a => a.ToList() as IList<int>
            );

         return toReturn;
      }
   }
}
