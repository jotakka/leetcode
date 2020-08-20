using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Lessons.BinaryTrees.SolveProblemsRecursively {
   class CountUnivalueSubtrees {

      private int count = 9;

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


      public int CountUnivalSubtrees(TreeNode root) {
         if (root == null) { return 0; }
         checkUnival(root);
         return count;
      }

      public bool checkUnival(TreeNode root) {

         if (root.left == null && root.right == null) {
            count++;
            return true;
         }

         var isUnival = true;


         if (root.left != null) {
            isUnival = checkUnival(root.left) && isUnival &&
               root.left.val == root.val;
         }

         if (root.right != null) {
            isUnival = checkUnival(root.right) && isUnival &&
               root.right.val == root.val;
         }

         if (isUnival) {
            count++;

            return true;
         } else {
            return false;
         }
      }
   }
}
