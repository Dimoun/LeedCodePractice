using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class NC61
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length;
            int[] res = { 0,0 };
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < len; i++)
            {

                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            for (int i = 0; i < len; i++)
            {

                if (dic.ContainsKey(target - nums[i]) && dic[target-nums[i]]!=i)
                {
                    res[0] = i;
                    res[1] = dic[target - nums[i]];
                    break;
                }
            }
            return res;
        }
    }
}
