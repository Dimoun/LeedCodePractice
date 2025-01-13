using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    internal class Classics_11
    { 
        public int MaxArea(int[] height)
        {
            int max = 0;
            int i = 0, j = height.Length - 1;
            while (i<j)
            {
                max = Math.Max(max, (j - i) * Math.Min(height[i], height[j]));

                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return  max;
        }
    }
}
