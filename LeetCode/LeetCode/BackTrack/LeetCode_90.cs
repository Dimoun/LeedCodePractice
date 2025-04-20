using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BackTrack
{
    public class LeetCode_90
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            BackTracking(0, nums);
            return res;
        }

        public void BackTracking(int startIndex, int[] nums)
        {
            res.Add(new List<int>(path));
            int len = nums.Length;
            for (int i = startIndex; i < len; i++)
            {
                if (i > startIndex && nums[i - 1] == nums[i])
                {
                    continue;
                }

                path.Add(nums[i]);
                BackTracking(i + 1, nums);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
