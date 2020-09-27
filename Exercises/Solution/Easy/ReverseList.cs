using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class ReverseList {
      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int x) {
            val = x;
            next = null;
         }
      }
      public ListNode reverseList(ListNode head) {
         var queue = new Queue<ListNode>();
         var node = head;
         ListNode last = null;
         ListNode next;
         while (node != null) {
            next = node.next;
            node.next = last;
            last = node;
            node = next;
         }
         return last;
      }
   }
}
