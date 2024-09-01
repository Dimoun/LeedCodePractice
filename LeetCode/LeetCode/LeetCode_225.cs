using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class LeetCode_225
    {
        //Method 1
        //public class MyStack
        //{
        //    Queue<int> queue1 ;
        //    Queue<int> queue2 ;
        //    public MyStack()
        //    {
        //        queue1 = new Queue<int>();
        //        queue2 = new Queue<int>();
        //    }

        //    public void Push(int x)
        //    {
        //        while(queue1.Count > 0)
        //        {
        //            int first = queue1.Peek();
        //            queue1.Dequeue();
        //            queue2.Enqueue(first);
        //        }
        //        queue1.Enqueue(x);
        //        while(queue2.Count > 0)
        //        {
        //            int last = queue2.Peek();
        //            queue1.Enqueue(last);
        //            queue2.Dequeue();
        //        }
        //    }

        //    public int Pop()
        //    {
        //        int top = queue1.Peek();
        //        queue1.Dequeue();
        //        return top;
        //    }

        //    public int Top()
        //    {
        //        return queue1.Peek(); ;
        //    }

        //    public bool Empty()
        //    {
        //        return queue1.Count>0?false:true;
        //    }
        //}

        //Method 2
        public class MyStack
        {
            Queue<int> queue;
            public MyStack()
            {
                queue = new Queue<int>();
            }

            public void Push(int x)
            {
                int size = queue.Count;
                queue.Enqueue(x);
                for(int i = 0; i <size; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }

            public int Pop()
            {
                return queue.Dequeue();
            }

            public int Top()
            {
                return queue.Peek(); ;
            }

            public bool Empty()
            {
                return queue.Count == 0 ? true : false;
            }
        }
    }
}
