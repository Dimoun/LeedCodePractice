using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class LeetCode_1115
    {
        private int n;
        private AutoResetEvent foo = new AutoResetEvent(true);
        private AutoResetEvent bar = new AutoResetEvent(false);

        public LeetCode_1115(int n)
        {
            this.n = n;
        }

        public void Foo()
        {

            for (int i = 0; i < n; i++)
            {
                foo.WaitOne();
                // printFoo() outputs "foo". Do not change or remove this line.
                //printFoo();
                Console.Write("foo");
                bar.Set();
            }
        }

        public void Bar()
        {

            for (int i = 0; i < n; i++)
            {
                bar.WaitOne();
                // printBar() outputs "bar". Do not change or remove this line.
                //printBar();
                Console.Write("bar");
                foo.Set();
            }
        }

        public void PrintFoo()
        {
            Console.Write("foo");
        }

        public void PrintBar()
        {
            Console.Write("bar");
        }
    }
}
