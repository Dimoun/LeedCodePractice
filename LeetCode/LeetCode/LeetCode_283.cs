using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class LeetCode_283
    {
        public void MoveZeroes(int[] nums)
        {
            int p = 0, q = 0;
            int len = nums.Length;
            int temp = 0;
            while (q < len)
            {
                if(nums[p] == 0)
                {
                    if(nums[q] != 0)
                    {
                        temp = nums[q];
                        nums[q] = nums[p];
                        nums[p] = temp;
                        p++;
                    }
                }
                else
                {
                    p++;
                }
                q++;
            }
        }
    }
}
