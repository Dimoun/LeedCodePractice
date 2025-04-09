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
        public int LeetCode_1005_LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums, (a, b) => Math.Abs(a) - Math.Abs(b));
            int len = nums.Length;
            int count = 0;
            for (int i = len-1; i >= 0 ; i--)
            {
                if (nums[i] < 0 && k > 0)
                {
                    nums[i] = -nums[i];
                    k--;
                }
            }

            if (k % 2 == 1)
            {
                nums[0] = -nums[0];
            }

            foreach (var value in nums)
            {
                count += value;
            }
            return count;
        }
        public int LeetCode_134_CanCompleteCircuit(int[] gas, int[] cost)
        {
            int curSum = 0, totalSum = 0, index = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                curSum += gas[i] - cost[i];
                totalSum += gas[i] - cost[i];
                if (curSum < 0)
                {
                    index = i + 1;
                    curSum = 0;
                }
            }

            if (totalSum < 0)
                return -1;
            return index;
        }
        public bool LeetCode_860_LemonadeChange(int[] bills)
        {
            int five = 0, ten = 0;
            foreach (var item in bills)
            {
                switch (item)
                {
                    case 5: five++;
                        break;
                    case 10:
                        if (five <= 0)
                            return false;
                        ten++;
                        five--;
                        break;
                    case 20:
                        if (five > 0 && ten > 0)
                        {
                            five--;
                            ten--;
                        }else if (five >= 3)
                        {
                            five -= 3;
                        }
                        else return false;

                        break;
                }
            }

            return true;
        }
    }
}
