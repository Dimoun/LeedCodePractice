using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_1313
    {
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < nums.Length/2; i++)
            {
                for(int j = 0; j < nums[2 * i]; j++)
                {
                    list.Add(nums[2 * i + 1]);
                }
            }
            return list.ToArray();
        }
    }
}
