using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.BackTrack
{
    public class LeetCode_78
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            BackTracking(0, nums);
            return res;
        }

        public void BackTracking(int startIndex, int[] nums)
        {
            res.Add(new List<int>(path));
            int len = nums.Length;

            for (int i = startIndex; i < len; i++)
            {
                path.Add(nums[i]);
                BackTracking(i + 1, nums);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
