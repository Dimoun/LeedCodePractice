using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.Greedy
{
    public class LeetCode_2591
    {
        public int DistMoney(int money, int children)
        {
            //按贪心思路，先每人分配一枚，保证都有分配，然后枚举出5种情况返回：
            //money -= children 
            //  判断                               分配                                 返回
            //  money<0                            不够分                                -1
            //  money>children*7                   富余，多余的全给最后一位             children-1
            //  money==children*7                  正好分完                             children
            //  money==children*7-4             最后一位分配4枚，牺牲最后两位互相调剂   children-2
            //  其他                         不用担心最后一位为4，可以和后续为1的调剂   money/7

            money = money - children;
            if (money < 0)
            {
                return -1;
            }
            int n = money / 7;
            int m = money % 7;

            if (n > children)
            {
                return children - 1;
            }
            else if (n == children)
            {
                if (m == 0)
                {
                    return n;
                }
                return n - 1;
            }

            if (m == 3 && n == children - 1)
            {
                return n - 1;
            }

            return n;
        }
    }
}
