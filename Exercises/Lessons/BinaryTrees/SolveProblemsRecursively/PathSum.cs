using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Lessons.BinaryTrees.SolveProblemsRecursively {
   class PathSum {
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


      public bool pathSum(TreeNode root, int partialSum, in int sum) {
         if(root == null) { return false; }
         if (root.left == null && root.right == null) {
            return (partialSum + root.val) == sum;
         }

         return pathSum(root.left, partialSum + root.val, sum)
            || pathSum(root.right, partialSum + root.val, sum);
      }


      public bool HasPathSum(TreeNode root, int sum) {
         return pathSum(root, 0, sum);
      }

   }
}
