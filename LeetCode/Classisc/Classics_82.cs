using LeetCode.LeetCode.LinkedTable;
using LeetCode.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_82
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode dummy = new ListNode(-1);
            ListNode cur = dummy;
            cur.next = head;

            while (cur.next != null && cur.next.next != null)
            {
                if (cur.next.val == cur.next.next.val)
                {
                    int value = cur.next.val;
                    while (cur.next != null && cur.next.val == value)
                    {
                        cur.next = cur.next.next;
                    }
                }
                else
                {
                    cur = cur.next;
                }
            }

            return dummy.next;
        }
    }
}
