using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class IsValidBST {
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
      public bool ISValidBST(TreeNode root) {
         if (root == null) return true;
         return isValidBST(root, root.val, root.val);

      }

      public bool isValidBST(TreeNode root, int min, int max) {

         if (root == null) {
            return true;
         }

         if (root.left != null && root.left.val >= root.val
            || root.right != null && root.right.val <= root.val) {
            return false;
         }

         if (root.left != null && root.left.val > min) {
            return false;
         }
         if (root.right != null && root.right.val < max) {
            return false;
         }


         max = root.right == null ? 0 : root.right.val;
         min = root.left == null ? 0 : root.left.val;

         var isLeftValid = isValidBST(root.left, max, min);
         var isRightValid = isValidBST(root.right, max, min);

         return isLeftValid && isRightValid;
      }
   }
}
