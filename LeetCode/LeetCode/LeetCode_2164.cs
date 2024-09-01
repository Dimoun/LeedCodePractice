using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_2164
    {
        //排序算法
        public int[] SortEvenOdd(int[] nums)
        {
            int tempEven = 0;
            int tempOdd = 0;
            for (int i = 0; i < nums.Length - 2; i = i + 2)
            {
                for (int j = i; j < nums.Length - 2; j = j + 2)
                {
                    if (nums[i] > nums[j + 2])
                    {
                        tempOdd = nums[i];
                        nums[i] = nums[j + 2];
                        nums[j + 2] = tempOdd;
                    }
                }
            }
            for (int i = 1; i < nums.Length-2; i=i+2)
            {
                for (int j = i; j < nums.Length - 2; j = j + 2)
                {
                    if (nums[i] < nums[j + 2])
                    {
                        tempOdd = nums[i];
                        nums[i] = nums[j + 2];
                        nums[j + 2] = tempOdd;
                    }
                }
            }

            return nums;
        }

    }
}
