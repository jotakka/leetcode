using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class RotateRight {
      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
         }
      }
      public ListNode rotateRight(ListNode head, int k) {

         if (head == null || head.next == null) { return head; }

         var listSize = 0;
         var node = head;
         ListNode last = null;

         while (node != null) {
            last = node;

            node = node.next;
            listSize++;
         }
         var Kmod = k % listSize;
         if (Kmod == 0) { return head; }
         node = head;
         var cnt = 0;
         while (cnt != listSize - Kmod - 1) {
            node = node.next;
            cnt++;
         }

         last.next = head;
         head = node.next;
         node.next = null;

         return head;
      }
   }
}
