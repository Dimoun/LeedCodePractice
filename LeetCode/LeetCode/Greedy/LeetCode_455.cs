using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.Greedy
{
    public class LeetCode_455
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            int count = 0;
            Array.Sort(s);
            Array.Sort(g);
            int gIndex = g.Length-1; 
            int sIndex = s.Length-1;
            while (gIndex >= 0 && sIndex >= 0)
            {
                if (s[sIndex] >= g[gIndex])
                {
                    count++;
                    sIndex--;
                }
        
                gIndex--;
            }

            return count;
        }
    }
}
