using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_128
    {
        //输入：nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1]
        //输出：9
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (!set.Contains(nums[i]))
                {
                    set.Add(nums[i]);
                }
            }
            int maxLength = 0;
            foreach(int val in set){

                if(!set.Contains(val-1)){
                    int current = val;
                    int length = 1;
                    while(set.Contains(current+1)){
                        length ++;
                        current ++;
                    }
                    maxLength = Math.Max(maxLength,length);
                }
            }
            return maxLength;
        }
    }
}
