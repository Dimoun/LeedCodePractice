using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    public class LeetCode_1117
    {
        private SemaphoreSlim hSemaphore = new SemaphoreSlim(2, 2);
        private SemaphoreSlim oSemaphore = new SemaphoreSlim(0);
        public LeetCode_1117()
        {
        }

        public void Hydrogen(Action releaseHydrogen)
        {
            hSemaphore.Wait();
            releaseHydrogen();
            if (hSemaphore.CurrentCount == 0)
            {
                oSemaphore.Release();
            }
        }

        public void Oxygen(Action releaseOxygen)
        {
            oSemaphore.Wait();
            // releaseOxygen() outputs "O". Do not change or remove this line.
            releaseOxygen();
            hSemaphore.Release(2);
        }
    }
}
