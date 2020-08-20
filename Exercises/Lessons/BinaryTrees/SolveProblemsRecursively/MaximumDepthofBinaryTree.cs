using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Lessons.BinaryTrees.SolveProblemsRecursively {
   class MaximumDepthofBinaryTree {
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


      public int MaxDepth(TreeNode root) {
         
         if(root == null) {
            return 0;
         }

         if(root.left == null && root.right == null) {
            return 1;
         }

         return Math.Max(
            MaxDepth(root.left) + 1,
            MaxDepth(root.right) + 1
            ); ; 

      }
   }
}
