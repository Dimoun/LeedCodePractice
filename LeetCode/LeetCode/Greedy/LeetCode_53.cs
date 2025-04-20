using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy
{
    public class LeetCode_53
    {
        public int MaxSubArray(int[] nums)
        {
            int res = int.MinValue;
            int len = nums.Length;
            int count = 0;
            for (int j = 0; j < len; j++)
            {
                count += nums[j];
                res = Math.Max(res, count);
                if (count < 0)
                {
                    count = 0;
                }
            }

            return res;
        }
    }
}
