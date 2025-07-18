using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.LinkedTable
{
  //Definition for singly-linked list.
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

    public class LinkedTable
    {
        public ListNode LeetCode_203_RemoveElements(ListNode head, int val)
        {
            ListNode node = new ListNode(-1, head);
            ListNode res = node;
            while (node.next!=null)
            {
                if (node.next.val == val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }

            return res.next;
        }

        public class MyLinkedList
        {
            private ListNode dummyHead;
            private int count = 0;
            public MyLinkedList()
            {
                dummyHead = new ListNode(-1,null);
            }

            public int Get(int index)
            {
                if (count == 0 || count <= index) return -1;
                ListNode currentNode = dummyHead;
                for (int i = 0; i <= index; i++)
                {
                    currentNode = currentNode.next;
                }

                return currentNode.val;
            }

            public void AddAtHead(int val)
            {
                AddAtIndex(0,val);
            }

            public void AddAtTail(int val)
            {
                AddAtIndex(count, val);
            }

            public void AddAtIndex(int index, int val)
            {
                if(index > count) { return;}
         
                ListNode currentNode = dummyHead;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.next;
                }
                ListNode insertNode = new ListNode(val, currentNode.next);
                currentNode.next = insertNode;
                count++;
            
            }

            public void DeleteAtIndex(int index)
            {
                if (index >= count || index < 0) return;
                ListNode currentNode = dummyHead;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = currentNode.next.next;
                count--;
            }
        }
        public ListNode LeetCode_206_ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            //Method1 暴力解法
            //ListNode currentNode = head;
            //List<ListNode> list = new List<ListNode>(){currentNode};
            //while (currentNode.next != null)
            //{
            //    currentNode = currentNode.next;
            //    list.Add(currentNode);
            //}
            //ListNode res = currentNode;
            //for (int i = list.Count-2; i >= 0; i--)
            //{
            //    currentNode.next = list[i];
            //    currentNode = currentNode.next;
            //}

            //currentNode.next = null;
            //return res;

            //Method2 双指针
            ListNode pre = null, cur = head, temp = null;
            while (cur != null)
            {
                temp = cur.next;
                cur.next = pre;

                pre = cur;
                cur = temp;
            }

            return pre;
        }
        public ListNode LeetCode_24_SwapPairs(ListNode head)
        {
            ListNode dummNode = new ListNode(-1, head);
            ListNode pre, cur = dummNode, temp = null;

            while (cur.next != null && cur.next.next != null)
            {
                temp = cur.next.next;
                pre = cur.next;
                pre.next = temp.next;

                
                cur.next = temp;
                cur.next.next = pre;
                cur = cur.next.next;
            }

            return dummNode.next;
        }
        public ListNode LeetCode_19_RemoveNthFromEnd(ListNode head, int n)
        {
            ////Method1 循环解法
            //ListNode dummNode = new ListNode(-1, head);
            //ListNode cur = dummNode;
            //int count = 0;
            //while (cur.next != null)
            //{
            //    count++;
            //    cur = cur.next;
            //}

            //int index = count - n + 1;
            //cur = dummNode;
            //while (cur.next != null && index > 1)
            //{
            //    index--;
            //    cur = cur.next;
            //}

            //cur.next = cur.next.next;

            //return dummNode.next;

            //Method2 双指针
            ListNode dummNode = new ListNode(-1, head);
            ListNode slow = dummNode, fast = dummNode;
            int index = n;
            while (index > 0)
            {
                index--;
                fast = fast.next;
            }

            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;

            return dummNode.next;
        }
        public ListNode LeetCode_160_GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ////Method1 暴力解法
            //ListNode nodeA = headA,
            //    nodeB = headB;
            //while (nodeA != null)
            //{
            //    nodeB = headB;
            //    while (nodeB != null)
            //    {
            //        if (nodeA == nodeB)
            //        {
            //            return nodeA;
            //        }
            //        else
            //        {
            //            nodeB = nodeB.next;
            //        }
            //    }

            //    nodeA = nodeA.next;
            //}

            //return null;

            //Method2 双指针，将A/B合并
            ListNode nodeA = headA,
                nodeB = headB;
            while (nodeA!=nodeB)
            {
                nodeA = nodeA == null ? headB : nodeA.next;
                nodeB = nodeB == null ? headA : nodeB.next;
            }

            return nodeA;
        }
        public ListNode LeetCode_142_DetectCycle(ListNode head)
        {
            ListNode slow = head,fast = head;
            while (fast!=null && fast.next!=null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (slow == fast)
                {
                    fast = head;
                    while (fast != slow)
                    {
                        fast = fast.next;
                        slow = slow.next;
                    }

                    return fast;
                }
            }

            return null;
        }
    }
}
