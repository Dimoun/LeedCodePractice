using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BackTrack
{
    public class LeetCode_216
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> path = new List<int>();

            BackTracking(1, 0, k, n, path, res);

            return res;
        }

        public void BackTracking(int startIndex, int sum, int k, int n, IList<int> path, IList<IList<int>> res)
        {
            int count = path.Count;
            if (count == k)
            {
                if (sum == n)
                {
                    res.Add(new List<int>(path));
                }
                return;
            }

            for (int i = startIndex; i <= 9 - (k - count) + 1; i++)
            {
                path.Add(i);
                sum += i;
                if (sum > n)
                {
                    sum -= i;
                    path.Remove(i);
                    return;
                }
                BackTracking(i + 1, sum, k, n, path, res);
                sum -= i;
                path.Remove(i);
            }
        }
    }
}
