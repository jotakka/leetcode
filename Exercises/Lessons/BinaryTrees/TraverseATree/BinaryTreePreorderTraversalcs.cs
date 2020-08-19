using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Lessons.BinaryTrees.TraverseATree {
   class BinaryTreePreorderTraversalcs {

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
      public IList<int> PreorderTraversal(TreeNode root) {
         if (root == null) return new List<int>();
         var nodeStack = new Stack<TreeNode>();
         var ansList = new List<int>();
         nodeStack.Push(root);
         while (nodeStack.Any()) {
            var curr = nodeStack.Pop();
            ansList.Add(curr.val);
            
            if(curr.right != null) {
               nodeStack.Push(curr.right);
            }

            if(curr.left != null) {
               nodeStack.Push(curr.left);
            }

         } 
         return ansList;
      }
   }
}

