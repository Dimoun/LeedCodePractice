using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_1114
    {
        //Method 1 添加标志位
            bool firstFinish = false;
            bool secondFinish = false;

        //Method 2 AutoResetEvent 
        AutoResetEvent _second = new AutoResetEvent(false);
        AutoResetEvent _three = new AutoResetEvent(false);

        //Method 3 自旋锁
        private SpinWait _spinWait = new SpinWait();
        private int _continueCondition = 1;

        public LeetCode_1114()
        {

        }

        public void First(Action printFirst)
        {
            ////Method 1
            //// printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            firstFinish = true;

            //Method 2
            printFirst();
            _second.Set();

            //Method 3
            printFirst();
            Thread.VolatileWrite(ref _continueCondition, 2);

        }

        public void Second(Action printSecond)
        {
            //Method 1
            // printSecond() outputs "second". Do not change or remove this line.
            while (!firstFinish)
            {
                Thread.Sleep(1);
            }
            printSecond();
            secondFinish = true;

            //Method 2
            _second.WaitOne();
            printSecond();
            _three.Set();

            //Method 3
            while(Thread.VolatileRead(ref _continueCondition) != 2)
            {
                _spinWait.SpinOnce();
            }
            printSecond();
            Thread.VolatileWrite(ref _continueCondition, 3);
        }

        public void Third(Action printThird)
        {
            //Method 1
            // printThird() outputs "third". Do not change or remove this line.
            while (!(secondFinish && firstFinish))
            {
                Thread.Sleep(1);
            }
            printThird();


            //Method 2
            _three.WaitOne();
            printThird();

            //Method 3
            while(Thread.VolatileRead(ref _continueCondition) != 3)
            {
                _spinWait.SpinOnce();
            }
            printThird();
            Thread.VolatileWrite(ref _continueCondition, 1);
        }

    }
}

