using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_45
    {
        public int Jump(int[] nums)
        {
            int len = nums.Length;
            int index = 0;
            int max = 0;
            int border = 0;
            for(int i = 0; i < len-1; i++)
            {
                max = Math.Max(max, nums[i] + i);

                if (i==border)
                {
                    border = max;
                    index++;
                }
            }
            return index;
        }
    }
}
