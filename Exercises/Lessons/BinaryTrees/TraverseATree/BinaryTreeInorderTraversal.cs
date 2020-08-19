using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Lessons.BinaryTrees.TraverseATree {
   class BinaryTreeInorderTraversal {
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
      public IList<int> InorderTraversal(TreeNode root) {
         if (root == null) { return new List<int>(); }
         var stack = new Stack<TreeNode>();
         var list = new List<int>();
         var curr = root;
         while (curr != null || stack.Any()) {

            while (curr != null) {
               stack.Push(curr);
               curr = curr.left;
            }

            curr = stack.Pop();
            list.Add(curr.val);
            curr = curr.right;
         }
         return list;
      }
   }
}
