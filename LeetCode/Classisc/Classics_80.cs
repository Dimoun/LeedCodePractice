using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_80
    {
        public int RemoveDuplicates(int[] nums)
        {
            //Mehtod 1
            //if (nums.Length == 1 || nums.Length == 2)
            //    return nums.Length;
            //int p = 0, q = 1;
            //while (q < nums.Length)
            //{
            //    if (nums[p]==nums[q])
            //    {
            //        if((p-1>=0) && nums[p] == nums[p - 1]){
            //            q++;
            //        }
            //        else
            //        {
            //            p++;
            //            nums[p] = nums[q];
            //            q++;
            //        }
            //    }
            //    else
            //    {
            //        p++;
            //        nums[p] = nums[q];
            //        q++;
            //    }
            //}

            //return p+1;

            //Method 2
            int n = nums.Length;
            if (n <= 2)
            {
                return n;
            }
            int slow = 2, fast = 2;
            while (fast < n)
            {
                if(nums[slow-2] != nums[fast])
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            return slow;
        }
    }
}
