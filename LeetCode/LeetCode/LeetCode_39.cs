using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class LeetCode_39
    {
        private IList<IList<int>> res = new List<IList<int>>();
        private IList<int> path = new List<int>();
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            BackTracking(0,candidates, target, 0);
            return res;
        }

        public void BackTracking(int startIndex, int[] candidates,int target,int sum)
        {
            if( sum == target)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = startIndex; i < candidates.Length && sum+candidates[i] <= target; i++)
            {
                path.Add(candidates[i]);
                sum += candidates[i];
                BackTracking(i,candidates, target,sum);
                path.Remove(candidates[i]);
                sum -= candidates[i];
            }
        }
    }
}
