using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Lessons.BinaryTrees.TraverseATree {
   class BinaryTreeLevelOrderTraversal {
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

      public IList<IList<int>> LevelOrder(TreeNode root) {
      
         var ouput = new List<IList<int>>();
         var q = new Queue<TreeNode>();
         if (root != null) {
            q.Enqueue(root);
         }

         while(q.Any()) {
            var size = q.Count;
            var subAns = new List<int>();
            for (int i = 0; i < size; i++) {
               var curr = q.Dequeue();
               subAns.Add(curr.val);
               if (curr.left!=null) {
                  q.Enqueue(curr.left);
               }
               if(curr.right != null) {
                  q.Enqueue(curr.right);
               }
            }

            ouput.Add(subAns);
         }


         return ouput;
      }
   }
}
