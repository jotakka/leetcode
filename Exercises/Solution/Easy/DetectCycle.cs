using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class DetectCycle {

      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int x) {
            val = x;
            next = null;
         }
      }
      public ListNode detectCycle(ListNode head) {

         var hashSet = new HashSet<ListNode>();
         var node = head;
         while (node != null) {
            if (hashSet.Contains(node)) {
               return node;
            } else {
               hashSet.Add(node);
            }
            node = node.next;
         }
         return null;
      }
   }
}
