using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    public class LeetCode_1523
    {
        public int CountOdds(int low, int high)
        {
            int n = 0;

            if (low % 2 == 0)
            {
                n = (high - (low + 1)) / 2;
                if (low == high)
                {
                    return 0;
                }
            }
            else
            {
                n = (high - low) / 2;
            }

            return n + 1;
        }
    }
}
