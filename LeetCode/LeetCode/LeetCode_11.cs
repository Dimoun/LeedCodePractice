using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class LeetCode_11
    {
        public int MaxArea(int[] height)
        {
            int max = 0;
            int min = 0;
            int i = 0,
                j = height.Length - 1;
            while (i < j)
            {
                min = Math.Min(height[i], height[j]);
                max = Math.Max(max, (j - i) * min);
                if (height[i] > height[j]) 
                { 
                      j--;
                }
                else
                {
                    i++;
                }
            }
            return max;
        }
    }
}
