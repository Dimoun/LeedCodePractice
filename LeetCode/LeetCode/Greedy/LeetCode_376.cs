using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.Greedy
{
    public class LeetCode_376
    {
        //public int WiggleMaxLength(int[] nums)
        //{
        //    int len = nums.Length;
        //    if (len < 2)
        //        return len;
        //    int res = 1, cur = 0;
        //    int pre = 0;
        //    for (int i = 0; i < len - 1; i++)
        //    {
        //        cur = nums[i + 1] - nums[i];
        //        if ((cur > 0 && pre <= 0) || (cur < 0 && pre >= 0))
        //        {
        //            pre = cur;
        //            res++;
        //        }
        //    }

        //    return res;
        //}
        public int WiggleMaxLength(int[] nums)
        {
            int len = nums.Length;
            if (len <= 2)
                return len;
            int res = 1;
            bool flag = nums[1] - nums[0] > 0;
            int temp = nums[0];
            for (int i = 1; i < len; i++)
            {
                if (nums[i] - temp > 0 == !flag)
                {
                    flag = !flag;
                    res++;
                }
                temp = nums[i];
            }

            return res;
        }
    }
}
