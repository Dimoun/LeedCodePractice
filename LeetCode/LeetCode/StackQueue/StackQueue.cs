using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.StackQueue
{
    public class StackQueue
    {
        public class MyQueue
        {
            private Stack<int> stackIn;
            private Stack<int> stackOut;

            public MyQueue()
            {
                stackIn = new Stack<int>();
                stackOut = new Stack<int>();
            }

            public void Push(int x)
            {
                int outCount = stackOut.Count;
                for (int i = 0; i < outCount; i++)
                {
                    stackIn.Push(stackOut.Pop());
                }

                stackIn.Push(x);
                int inCount = stackIn.Count;
                for (int i = 0; i < inCount; i++)
                {
                    stackOut.Push(stackIn.Pop());
                }
            }

            public int Pop()
            {
                return stackOut.Pop();
            }

            public int Peek()
            {
                return stackOut.Peek();
            }

            public bool Empty()
            {
                return stackOut.Count == 0 ? true : false;
            }
        }

        public StackQueue()
        {
            //MyQueue mq = new MyQueue();
            //mq.Push(1);
            //mq.Push(2);
            //mq.Push(3);
            //mq.Push(4);
            //mq.Peek();
            //mq.Pop();
            //mq.Push(5);
            //mq.Empty();

            //MyStack myStack = new MyStack();
            //myStack.Push(1);
            //myStack.Push(2);
            //myStack.Top(); // 返回 2
            //myStack.Pop(); // 返回 2
            //myStack.Empty(); // 返回 False

        }

        public class MyStack
        {
            private Queue<int> inQueue;
            private Queue<int> outQueue;

            public MyStack()
            {
                inQueue = new Queue<int>();
                outQueue = new Queue<int>();
            }

            public void Push(int x)
            {
                inQueue.Enqueue(x);
                while (outQueue.Count != 0)
                {
                    inQueue.Enqueue(outQueue.Dequeue());
                }

                var temp = inQueue;
                inQueue = outQueue;
                outQueue = temp;

            }

            public int Pop()
            {
                return outQueue.Dequeue();
            }

            public int Top()
            {
                return outQueue.Peek();
            }

            public bool Empty()
            {
                return outQueue.Count == 0;
            }
        }

        public bool LeetCode_20_IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count != 0)
                {
                    char ch = stack.Peek();
                    bool isExisted = false;
                    switch (s[i])
                    {
                        case ')':
                            if (ch == '(')
                            {
                                isExisted = true;
                            }

                            break;
                        case ']':
                            if (ch == '[')
                            {
                                isExisted = true;
                            }

                            break;
                        case '}':
                            if (ch == '{')
                            {
                                isExisted = true;
                            }

                            break;
                    }

                    if (isExisted)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(s[i]);
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return stack.Count == 0;
        }

        public string LeetCode_1047_RemoveDuplicates(string s)
        {
            //Method 1
            //Stack<char> stack = new Stack<char>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (stack.Count!=0 &&  stack.Peek() == s[i])
            //    {
            //        stack.Pop();
            //    }
            //    else
            //    {
            //        stack.Push(s[i]);
            //    }
            //}

            //char[] result = stack.Reverse().ToArray();  
            //return new string(result);

            //Method2 
            StringBuilder sb = new StringBuilder();
            foreach (var item in s)
            {
                if (sb.Length > 0 && sb[sb.Length - 1] == item)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }

        public int[] LeetCode_239_MaxSlidingWindow(int[] nums, int k)
        {
            //Method1 暴力解法 超时
            //int[] res = new int[nums.Length-k+1];
            //for (int i = 0; i < nums.Length-k+1; i++)
            //{
            //    int max = int.MinValue;
            //    for (int j = i; j < i+k; j++)
            //    {
            //        max = Math.Max(max, nums[j]);
            //    }
            //    res[i] = max;
            //}
            //return res;
            //Method2 优先队列
            PriorityQueue<int,int> priorityQueue = new PriorityQueue<int,int>();
            int[] res = new int[nums.Length-k+1];
            for (int i = 0; i < k-1; i++)
            {
                priorityQueue.Enqueue(i, -nums[i]);
            }

            for (int i = k-1; i < nums.Length; i++)
            {
                priorityQueue.Enqueue(i, -nums[i]);
                while (priorityQueue.Peek() < i-k+1)
                {
                    priorityQueue.Dequeue();
                }

                res[i - k + 1] = nums[priorityQueue.Peek()];
            }
            return res;

        }

        public int[] LeetCode_347_TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] res = new int[k];
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                }
                else
                {
                    dic[nums[i]]++;
                }
            }

            //Medhod 1
            //var sorted = dic.OrderByDescending(item => item.Value).ToList();
            //for (int i = 0; i < k; i++)
            //{
            //    res[i] = sorted[i].Key;
            //}

            //return res;
            //Method2
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            foreach (var item in dic)
            {
                queue.Enqueue(item.Key, item.Value);
                if (queue.Count > k)
                {
                    queue.Dequeue();
                }
            }

            for (int i = 0; i < k; i++)
            {
                res[i] = queue.Dequeue();
            }

            return res;
        }

        public int LeetCode_150_EvalRPN(string[] tokens)
        {
            Stack<int> res = new Stack<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (!int.TryParse(tokens[i], out int num))
                {
                    int sec = res.Pop();
                    int fir = res.Pop();
                    int sum = 0;
                    switch (tokens[i])
                    {
                        case "+":
                            sum = fir + sec;
                            break;
                        case "-":
                            sum = fir - sec;
                            break;
                            break;
                        case "*":
                            sum = fir * sec;
                            break;
                        case "/":
                            sum = fir / sec;
                            break;
                    }

                    res.Push(sum);
                }else
                {
                    res.Push(num);
                }
            }

            return res.Pop();
        }
    }
}
