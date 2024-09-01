using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_27
    {
        public int RemoveElement(int[] nums, int val)
        {
            
            int left = 0;
            int right = nums.Length;
            int temp;
            while(left < right)
            {
                if(nums[left] == val)
                {
                    nums[left] = nums[right-1];
                    right--;
                }
                else
                {
                    left++;
                }

            }
            return left;
        }
    }
}
