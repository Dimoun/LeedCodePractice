using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    class LeetCode_232
    {
        public class MyQueue
        {
            Stack<int> stack1;
            Stack<int> stack2;
            public MyQueue()
            {
                stack1 = new Stack<int>();
                stack2 = new Stack<int>();
            }

            public void Push(int x)
            {
                if (stack2.Count > 0)
                {
                    int count = stack2.Count;
                    for (int i = 0; i < count; i++)
                    {
                        stack1.Push(stack2.Pop());
                    }
                }
                stack1.Push(x);
                int size = stack1.Count;
                for (int i = 0; i < size; i++)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            public int Pop()
            {
                return stack2.Pop();
            }

            public int Peek()
            {
                return stack2.Peek();
            }

            public bool Empty()
            {
                return stack2.Count == 0 ? true : false;
            }
        }

    }
}
