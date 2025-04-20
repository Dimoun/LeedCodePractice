using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    public class LeetCode_1195
    {
        private int n;
        //Method 1
        Barrier barrier = new Barrier(4);

        //Method 2
        private SemaphoreSlim _SemaphoreFizz = new SemaphoreSlim(0, 1);
        private SemaphoreSlim _SemaphoreBuzz = new SemaphoreSlim(0, 1);
        private SemaphoreSlim _SemaphoreFizzbuzz = new SemaphoreSlim(0, 1);
        private SemaphoreSlim _SemaphoreNumber = new SemaphoreSlim(1, 1);
        public LeetCode_1195(int n)
        {
            this.n = n;
        }

        // printFizz() outputs "fizz".
        public void Fizz(Action printFizz)
        {
            //Method 1
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    printFizz();
                }
                barrier.SignalAndWait();
            }

            //Method 2
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    _SemaphoreFizz.Wait();
                    printFizz();
                    _SemaphoreNumber.Release();
                }
            }


        }

        // printBuzzz() outputs "buzz".
        public void Buzz(Action printBuzz)
        {
            //Method 1
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 5 == 0)
                {
                    printBuzz();
                }
                barrier.SignalAndWait();
            }

            //Method 2
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 5 == 0)
                {
                    _SemaphoreBuzz.Wait();
                    printBuzz();
                    _SemaphoreNumber.Release();
                }
            }
        }

        // printFizzBuzz() outputs "fizzbuzz".
        public void Fizzbuzz(Action printFizzBuzz)
        {
            //Method 1
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    printFizzBuzz();
                }
                barrier.SignalAndWait();
            }

            //Method 2
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    _SemaphoreFizzbuzz.Wait();
                    printFizzBuzz();
                    _SemaphoreNumber.Release();
                }
            }
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Number(Action<int> printNumber)
        {
            //Method 1
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    printNumber(i);
                }
                barrier.SignalAndWait();
            }

            //Method 2
            for (int i = 1; i <= n; i++)
            {
                _SemaphoreNumber.Wait();
                if (i % 3 == 0 && i % 5 != 0)
                {
                    _SemaphoreFizz.Release();
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    _SemaphoreBuzz.Release();
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    _SemaphoreFizzbuzz.Release();
                }
                else
                {
                    printNumber(i);
                    _SemaphoreNumber.Release();
                }
            }
        }
    }
}
