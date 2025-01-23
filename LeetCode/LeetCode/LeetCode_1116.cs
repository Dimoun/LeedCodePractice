using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class LeetCode_1116
    {
        private int n;
        private AutoResetEvent zero = new AutoResetEvent(true);
        private AutoResetEvent even = new AutoResetEvent(false);
        private AutoResetEvent odd = new AutoResetEvent(false);

        public LeetCode_1116(int n)
        {
            this.n = n;
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Zero(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i++)
            {
                zero.WaitOne();
                printNumber(0);
                if (i % 2 == 0)
                {
                    even.Set();
                }
                else
                {
                    odd.Set();
                }
            }
        }

        public void Even(Action<int> printNumber)
        {
            for (int i = 2; i <= n; i=i+2)
            {
                even.WaitOne();
                printNumber(i);
                zero.Set();
            }
        }

        public void Odd(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i=i+2)
            {
                odd.WaitOne();
                printNumber(i);
                zero.Set();
            }
        }
    }
}
