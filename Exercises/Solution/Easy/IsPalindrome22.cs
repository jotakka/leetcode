using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Exercises.Solution.Easy {
   class IsPalindrome22 {
      public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
         }
      }
      public bool isPalindrome(ListNode head) {
         if (head == null || head.next == null) { return true; }
         var stack = new Stack<int>();
         var node = head;
         while (node != null) {
            stack.Push(node.val);
            node = node.next;
         }
         node = head;
         while (stack.Any()) {
            if (stack.Pop() == node.val) {
               node = node.next;
            } else {
               return false;
            }
         }
         return true;
      }
   }
}
