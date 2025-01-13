using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    internal class Classics_3
    {
        public int LengthOfLongestSubstring(string s)
        {
            string res="";
            int max = 0;
            int j = 0;
            int len = s.Length;
            while (j<len)
            {
                if (!res.Contains(s[j]))
                {
                    res +=(s[j]);
                }
                else
                {
                    int index = res.IndexOf(s[j]);
                    res = res.Substring(index+1);
                    res += (s[j]);
                }

                max = Math.Max(max, res.Length);

                j++;
            }

            return max;

        }
    }
}
