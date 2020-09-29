using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class DeleteNode {
      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int x) { val = x; }
      }
      public void deleteNode(ListNode node) {
         var next = node.next;
         node.val = next.val;
         node.next = next.next;
         next.next = null;
      }
   }
}
