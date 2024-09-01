using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_754
    {
        public int ReachNumber(int target)
        {
            target = Math.Abs(target);
            int steps = 0, total = 0;
            while (target - total > 0 || ((total - target) & 1) == 1)
            {
                steps++;
                total += steps;
            }
            return steps;
        }
    }
}
