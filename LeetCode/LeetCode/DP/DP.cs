using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.DP
{
    public class DP
    {
        public int LeetCode_509_Fib(int n)
        {
            //// Method 1
            //if (n == 0 )
            //    return 0;
            //if (n == 1)
            //    return 1;
            //return LeetCode_509_Fib(n - 1) + LeetCode_509_Fib(n - 2);

            //Method 2
            if (n < 2)
                return n;
            int[] dp = new int[]{0,1};

            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum = dp[0] + dp[1];
                dp[0] = dp[1];
                dp[1] = sum;
            }

            return sum;
        }

        public int LeetCode_70_ClimbStairs(int n)
        {
            if (n < 2)
                return n;
            int[] dp = new int[n];
            dp[0] = 1;
            dp[1] = 2;
            for (int i = 2; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n-1];
        }
        public int LeetCode_746_MinCostClimbingStairs(int[] cost)
        {
            int len = cost.Length;
            int[] dp = new int[] { cost[0], cost[1] };
            int temp = 0;
            for (int i = 2; i < cost.Length; i++)
            {
                temp = Math.Min(dp[0], dp[1]) + cost[i];
                dp[0] = dp[1];
                dp[1] = temp;
            }

            return Math.Min(dp[0], dp[1]);
        }
        public int LeetCode_62_UniquePaths(int m, int n)
        {
            int[,] dp = new int[m,n];
            for (int i = 0; i < m; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                dp[0, i] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }
            return dp[m - 1, n - 1];
        }
        public int LeetCode_63_UniquePathsWithObstacles(int[][] obstacleGrid)
        {

        }

    }
}
