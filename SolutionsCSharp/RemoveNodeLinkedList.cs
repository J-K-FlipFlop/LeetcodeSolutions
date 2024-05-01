using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class RemoveNodeLinkedList
    {
        public static ListNode RemoveNth(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode fast = dummy, slow = dummy;

            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;

            return dummy.next;
        }

        public static int CountNodes(ListNode head)
        {
            int count = 1;
            ListNode current = head;

            while(current.next != null)
            {
                ++count;
                current = current.next;
            }

            return count;
        }
    }
}
