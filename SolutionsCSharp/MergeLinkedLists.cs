using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    internal class MergeLinkedLists
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            int v1 = 0, v2 = 0;

            while (l1 != null || l2 != null) 
            {
                if (l2 != null) { v2 = l2.val; } else { v2 = -1; }
                if (l1 != null) { v1 = l1.val; } else { v1 = v2 + 1; }

                if (v1 <= v2)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }

                current = current.next;
            }

            return dummy.next;
        }
    }
}
