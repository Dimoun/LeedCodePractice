using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_2154
    {
        public int FindFinalValue(int[] nums, int original)
        {
            //Method 1 暴力
            int j = 0;
            while (j < nums.Length)
            {
                if(nums[j] == original)
                {
                    original = nums[j] * 2;
                    j = 0;
                    continue;
                }
                j++;
            }

            return original;

            //Method 2 先排序再求解
            Array.Sort(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == original)
                {
                    original = nums[i] * 2;
                }
            }
            return original;

            //Method 3 哈希表
            HashSet<int> hashSet = new HashSet<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (!hashSet.Contains(nums[i]))
                {
                    hashSet.Add(nums[i]);
                }
            }
            while (hashSet.Contains(original))
            {
                original = original * 2;
            }

            return original;
        }
    }
}
