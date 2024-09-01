using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_908
    {
        public int SmallestRangeI(int[] nums, int k)
        {
            //垃圾题
            //Array.Sort(nums);
            //int min = (nums[0] + k);
            //int max = nums[nums.Length - 1] - k;
            //var res = nums[nums.Length - 1] - k - (nums[0] + k);
            //return res;

            //official
            int minNum = nums.Min();
            int maxNum = nums.Max();
            return maxNum - minNum <= 2 * k ? 0 : maxNum - minNum - 2 * k;

        }
    }
}
