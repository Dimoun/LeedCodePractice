using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BackTrack
{
    public class LeetCode_40
    {
        private IList<IList<int>> res = new List<IList<int>>();
        private IList<int> path = new List<int>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            BackTracking(0, 0, candidates, target);
            return res;
        }

        public void BackTracking(int startIndex, int sum, int[] candidates, int target)
        {
            if (sum == target)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = startIndex; i < candidates.Length && sum + candidates[i] <= target; i++)
            {
                if (i > startIndex && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                path.Add(candidates[i]);
                sum += candidates[i];
                BackTracking(i + 1, sum, candidates, target);
                path.Remove(candidates[i]);
                sum -= candidates[i];
            }
        }
    }
}
