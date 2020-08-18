using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Medium {
   public class AddTwoNumbers {

      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
         }
      }
      public ListNode solution(ListNode l1, ListNode l2) {

         if (l1 == null && l2 == null) { return null; }
         var toReturn = new ListNode();
         var returnNodePrev = toReturn;
         var currentL1 = l1;
         var currentL2 = l2;
         var toCarryNextIt = 0;
         var lastNode = toReturn;
         while (currentL1 != null || currentL2 != null) {
            var sum = currentL1 is null ? 0 : currentL1.val;
            sum += currentL2 is null ? 0 : currentL2.val;
            sum += toCarryNextIt;

            var valToAppend = (sum % (10));
            toCarryNextIt = sum / 10;
            returnNodePrev.val = (int)valToAppend;
            returnNodePrev.next = (currentL1?.next != null || currentL2?.next != null) ? new ListNode() : null;

            returnNodePrev = returnNodePrev.next ?? returnNodePrev;

            currentL1 = currentL1?.next;
            currentL2 = currentL2?.next;
         }

         if (toCarryNextIt != 0) {
            returnNodePrev.next = new ListNode(toCarryNextIt);
         }

         return toReturn;
      }
   }
}
