using LeetCode.LeetCode.LinkedTable;
using LeetCode.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{

    //Definition for singly-linked list.
    // public class ListNode
    //{
    //     public int val;
    //     public ListNode next;
    //     public ListNode(int x)
    //     {
    //        val = x;
    //        next = null;
    //     }
    //  }

    public class Classisc_141
    {
        public bool HasCycle(ListNode head)
        {
            //Method 1

            //if (head == null)
            //    return false;
            //ListNode next;
            //next = head;
            //Dictionary<ListNode, int> dic = new Dictionary<ListNode, int>();

            //while (next.next!= null)
            //{
            //    if(dic.ContainsKey(next))
            //    {
            //        return true;
            //    }
            //    dic.Add(next,0);
            //    next = next.next;
            //}
            //return false;

            //Method 2 快慢指针
            if (head == null|| head.next==null)
                return false;
            ListNode fast = head.next;
            ListNode slow = head;
            while (slow != fast)
            {
                if (fast.next == null || fast.next.next == null)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
