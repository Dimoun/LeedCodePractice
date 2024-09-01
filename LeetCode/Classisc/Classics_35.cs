using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_35
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length-1;
            int mid;

            if (nums[left] > target)
            {
                return 0;
            }
            if (nums[right] < target)
            {
                return right + 1;
            }
            while(left <= right)
            {
                mid = (left + right) / 2;

                if (nums[mid] < target)
                {
                    left = mid+1;
                }else if(nums[mid] > target) 
                {
                    right = mid - 1;
                }
                else if(nums[mid] == target)
                {
                    return mid;
                }
            }
            


            return left;
        }
    }
}
