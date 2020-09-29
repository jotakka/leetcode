using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class MergeTwoLists {

      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
         }
      }

      public ListNode mergeTwoLists(ListNode l1, ListNode l2) {
         if (l1 == null) { return l2; }
         if (l2 == null) { return l1; }
         var nodeL1 = l1;
         var nodeL2 = l2;
         var head = Min(ref nodeL2, ref nodeL1);
         var merged = head;
         while (nodeL1 != null & nodeL2 != null) {
            merged.next = Min(ref nodeL1, ref nodeL2);
            merged = merged.next;
         }

         if (nodeL2 == null) {
            merged.next = nodeL1;
         } else {
            merged.next = nodeL2;
         }

         return head;
      }

      private ListNode Min(ref ListNode l1, ref ListNode l2) {
         ListNode toReturn;
         if (l1.val > l2.val) {
            toReturn = l2;
            l2 = l2.next;
            return toReturn;
         } else {
            toReturn = l1;
            l1 = l1.next;
            return toReturn;
         }
      }
   }
}
