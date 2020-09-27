using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class GetIntersectionNode {
      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int x) {
            val = x;
            next = null;
         }
      }
      public ListNode getIntersectionNode(ListNode headA, ListNode headB) {
         if (headA == null || headB == null) { return null; }

         var p1 = headA;
         var p2 = headB;
         var hashSet = new HashSet<ListNode>();

         while (p1 != null || p2 != null) {

            if (hashSet.Contains(p1)) {
               return p1;
            } else if (p1 != null) {
               hashSet.Add(p1);
            }
            if (hashSet.Contains(p2)) {
               return p2;
            } else if (p2 != null) {
               hashSet.Add(p2);
            }


            p1 = p1?.next;
            p2 = p2?.next;
         }

         return null;
      }

   }
}
