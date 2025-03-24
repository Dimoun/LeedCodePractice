using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.BackTrack
{
    public class LeetCode_46
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        public IList<IList<int>> Permute(int[] nums)
        {
            bool[] used = new bool[nums.Length];
            BackTracking(used, nums);
            return res;
        }

        public void BackTracking(bool[] used, int[] nums)
        {
            int len = nums.Length;
            if (path.Count == len)
            {
                res.Add(new List<int>(path));
                return;
            }
            for (int i = 0; i < len; i++)
            {
                if (used[i] == true)
                    continue;
                path.Add(nums[i]);
                used[i] = true;
                BackTracking(used, nums);
                used[i] = false;
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
