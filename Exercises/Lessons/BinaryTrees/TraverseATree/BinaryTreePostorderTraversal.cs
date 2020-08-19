using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace leetcode.Exercises.Lessons.BinaryTrees.TraverseATree {
   class BinaryTreePostorderTraversal {
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
      public IList<int> PostorderTraversal(TreeNode root) {
         var stack = new Stack<TreeNode>();
         var list = new List<int>();
         var curr = root;
         while (curr != null || stack.Any()) {

            while (curr != null) {
               if (curr.right != null) {
                  stack.Push(curr.right);
               }
               stack.Push(curr);
               curr = curr.left;
            }

            curr = stack.Pop();

            if (stack.Any() && stack.Peek() == curr.right) {
               stack.Pop();
               stack.Push(curr);
               curr = curr.right;
            } else {
               list.Add(curr.val);
               curr = null;
            }

         }
         return list;
      }
   }
}
