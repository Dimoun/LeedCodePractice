using LeetCode.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_61
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k == 0 || head.next == null)
                return head;
            int count = 1;
            ListNode node = head;
            while (node.next != null)
            {
                count++;
                node = node.next;
            }
            node.next = head;

            int num = count - (k % count) ;
            int index = 0;
            while (index < num)
            {
                index++;
                node = node.next;
            }

            ListNode res = node.next;
            node.next = null;

            return res;

        }
    }
}
