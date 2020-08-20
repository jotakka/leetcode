using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace leetcode.Exercises.Lessons.BinaryTrees.SolveProblemsRecursively {
   class SymmetricTree {
      public class TreeNode {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
         }
      }


      private bool checkSymmetry(TreeNode rootL, TreeNode rootR) {


         if (rootL == null && rootR != null) {
            return true;
         } else if (rootL != null && rootR == null) {
            return rootL.val == rootR.val &&
               checkSymmetry(rootR.left, rootL.right) &&
               checkSymmetry(rootR.right, rootL.left);
         }

         return false;
      }


      public bool IsSymmetric(TreeNode root) {
         return root == null || checkSymmetry(root.right, root.left);

      }



   }
}
