using LeetCode.Classisc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
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
    public class LeetCode_2
    { 
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //Method 1
            //ListNode slowNode = null;
            //ListNode result = null;
            //int num = 0;
            //while(l1!=null || l2!=null)
            //{
            //    ListNode node = Add(ref num,l1, l2);
            //    if(slowNode == null)
            //    {
            //        result = slowNode = node;
            //    }
            //    else
            //    {
            //        slowNode.next = node;
            //        slowNode = slowNode.next;
            //    }
            //    if (l1 != null)
            //    {
            //        l1 = l1.next;
            //    }
            //    if (l2 != null)
            //    {
            //        l2 = l2.next;
            //    }
            //}
            //if(num > 0)
            //{
            //    slowNode.next = new ListNode(num);
            //}
            // return result;

            //Method 2
            ListNode slowNode = null;
            ListNode result = null;
            int carry = 0;
            int num = 0;
            while (l1 != null || l2 != null)
            {
                int n1 = l1 != null ? l1.val : 0;
                int n2 = l2 != null ? l2.val : 0;
                int sum = n1 + n2 + carry;
                if (slowNode == null)
                {
                    result = slowNode = new ListNode(sum % 10);
                }
                else
                {
                    slowNode.next = new ListNode(sum % 10);
                    slowNode = slowNode.next;
                }
                carry = sum / 10;
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
                if (carry > 0)
                {
                    result.next = new ListNode(carry);
                }
            }
     
            return result;

        }

        public ListNode Add(ref int num,ListNode l1, ListNode l2)
        {
            ListNode node = new ListNode(0,null);
            int sum = num;
            if(l1 == null)
            {
                sum = sum + l2.val;
            }else if(l2 == null)
            {
                sum = sum + l1.val;
            }
            else
            {
                sum = sum + l1.val + l2.val;
            }
            if (sum >= 10)
            {
                sum = (sum % 10);
                num = 1;
            }
            else
            {
                num = 0;
            }
            node.val = sum;

            return node;
        }
    }
}
