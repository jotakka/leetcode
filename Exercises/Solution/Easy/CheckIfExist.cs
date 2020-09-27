using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class CheckIfExist {
      public bool checkIfExist(int[] arr) {


         var hashSet = new HashSet<int>();

         for (int i = 0; i < arr.Length; i++) {


            if (hashSet.Contains(arr[i] / 2) && arr[i] % 2 == 0 || hashSet.Contains(arr[i] * 2)) { return true; }
            hashSet.Add(arr[i]);
         }

         return false;
      }

   }
}
