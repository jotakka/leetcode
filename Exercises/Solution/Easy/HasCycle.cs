using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class HasCycle {
      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int x) {
            val = x;
            next = null;
         }
      }

      public bool hasCycle(ListNode head) {
         if (head == null) { return false; }
         ListNode pointer1, pointer2;
         pointer1 = head;
         pointer2 = head;

         do {
            pointer1 = pointer1.next;
            pointer2 = pointer2.next?.next;

            if (pointer2 == null || pointer1 == null) {
               return false;
            }

         } while (pointer1 != pointer2);
         return true;
      }
   }
}
