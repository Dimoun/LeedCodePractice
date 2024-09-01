using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_2535
    {
        public int DifferenceOfSum(int[] nums)
        {
            int sum = 0;
            int sumNumber = 0;
            int temp = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                temp = nums[i];
                while (temp>9)
                {
                    sumNumber += temp % 10;
                    temp = temp / 10;
                }
                sumNumber += temp;
            }
            return Math.Abs(sum-sumNumber);
        }
    }
}
