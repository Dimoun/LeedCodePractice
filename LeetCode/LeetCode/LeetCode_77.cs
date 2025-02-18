using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class LeetCode_77
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> res = new List<IList<int>>();
            List<int> path = new List<int>();

            BackTracking(1,n,k,path,res);
            return res;
        }

        public void BackTracking(int startIndex, int n,int k,IList<int> path,IList<IList<int>> res)
        {
            if (path.Count == k)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = startIndex; i <= n-(k-path.Count)+1; i++)
            {
                path.Add(i);
                BackTracking(i+1,n,k,path,res);
                path.Remove(i);
            }
        }
    }
}
