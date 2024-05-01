using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class AddTwoNumbers
    {
        public static ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode current = result;
            int carry = 0;
            int v1, v2, val;

            while (l1 != null || l2 != null || carry!= 0)
            {
                if (l1 != null) { v1 = l1.val;}
                else { v1 = 0; }

                if (l2 != null) { v2 = l2.val;}
                else { v2 = 0; }

                val = v1 + v2 + carry;

                carry = val / 10;
                val = val % 10;

                current.next = new ListNode(val);
                current = current.next;

                l1 = l1.next;
                l2 = l2.next;
            }

            return result.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
