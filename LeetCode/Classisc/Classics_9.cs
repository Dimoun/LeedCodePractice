using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
                
            StringBuilder stringBuilder = new StringBuilder();
            int b = 0;
            while (x >= 10)
            {
                b = x % 10;
                x = x / 10;
                stringBuilder.Append(b);
            }
           stringBuilder.Append(x);
           string s = stringBuilder.ToString();
            for(int i = 0,j=s.Length-1 ; i <= s.Length/2 && j>=s.Length/2; i++,j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
