using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.BackTrack
{
    public class LeetCode_491
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            BackTracking(0, nums);
            return res;
        }

        public void BackTracking(int startIndex, int[] nums)
        {
            int len = nums.Length;

            if (path.Count >= 2)
            {
                res.Add(new List<int>(path));
            }
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = startIndex; i < len; i++)
            {
                if (path.Count > 0 && nums[i] < path[path.Count - 1] || hashSet.Contains(nums[i]))
                {
                    continue;
                }

                hashSet.Add(nums[i]);
                path.Add(nums[i]);
                BackTracking(i + 1, nums);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
