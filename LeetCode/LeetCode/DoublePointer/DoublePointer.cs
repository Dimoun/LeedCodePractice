using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.DoublePointer
{
    public class DoublePointer
    {
        public int LeetCode_27_RemoveElement(int[] nums, int val)
        {
            //int slow = 0;
            //for (int fast = 0; fast < nums.Length; fast++)
            //{
            //    if (nums[fast] != val)
            //    {
            //        nums[slow] = nums[fast];
            //        slow++;
            //    }
            //}
            //return slow;

            int left = 0,right = nums.Length - 1;
            while (left<=right)
            {
                if(nums[left] != val)
                {
                        left++;
                }else if (nums[left] == val )
                {
                    if (nums[right] != val)
                    {
                        int temp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = temp;
                        left++;
                        right--;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return left;
        }
    }
}
