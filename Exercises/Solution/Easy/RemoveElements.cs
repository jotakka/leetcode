using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class RemoveElements {
      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int x) {
            val = x;
            next = null;
         }
      }
      public ListNode removeElements(ListNode head, int val) {
         if (head == null) { return null; }

         var node = head;
         ListNode previous = null;
         while (node != null) {

            if (node.val == val) {
               var next = node?.next;
               while (next != null && next.val == val) {
                  next = next.next;
               }
               if (previous != null) {
                  previous.next = next;

               } else {
                  head = next;
               }
            }

            previous = node;
            node = node.next;

         }
         return head;
      }
   }
}
