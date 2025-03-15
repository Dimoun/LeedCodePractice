using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy
{
    public class Greedy
    {
        public int LeetCode_122_MaxProfit(int[] prices)
        {
            int res = 0;
            int len = prices.Length;

            for (int i = 1; i < len; i++)
            {
                res += Math.Max(prices[i] - prices[i-1],0);
            }

            return res;
        }
        public bool LeetCode_55_CanJump(int[] nums)
        {
            int len = nums.Length;

            if (len == 1)
                return true;
            int cover = 0;

            for (int j = 0; j <= cover; j++)
            {
                cover = Math.Max(nums[j]+j, cover);
                if (cover >= len-1)
                {
                    return true;
                }
            }
            return false;
        }

        public int LeetCode_45_Jump(int[] nums)
        {
            int cur = 0,step = 0,next = 0;
            int len = nums.Length;
            for (int i = 0; i < len-1; i++)
            {
                next = Math.Max(next, nums[i] + i);
                if (i == cur)
                {
                    step++;
                    cur = next;
                }
            }

            return step;
        }
    }
}
