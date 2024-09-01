using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewQ
{
    public class LCR_127
    {
        public int TrainWays(int num)
        {
            if (num < 2)
                return 1;
            const int mod = 1000000007;

            int p = 0, q = 0, r = 1;
            for(int i = 0; i < num; i++)
            {
                p = q;
                q = r;
                r = (p + q) % mod;
            }

            return r;

        }

        const int MODULO = 1000000007;
        IDictionary<int, int> memo = new Dictionary<int, int>();
        public int NumWays(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            if (!memo.ContainsKey(n))
            {
                memo.Add(n, (NumWays(n - 1) + NumWays(n - 2)) % MODULO);
            }
            return memo[n];
        }
    }
}
