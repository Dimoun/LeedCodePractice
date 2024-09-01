using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class LeetCode_1796
    {
        public int SecondHighest(string s)
        {
            char[] ch = s.ToCharArray();
            
            int second = -1;
            int max = -1;
            for(int i = 0; i < ch.Length; i++)
            {
                if(ch[i]>=48 && ch[i] <= 57)
                {
                    int temp = (int)Convert.ToInt32(ch[i]-'0');
                    if(temp > max)
                    {
                        second = max;
                        max = temp;
                    }
                    else if (temp == max)
                    {
                        continue;
                    }
                    else if(temp > second)
                    {
                        second = temp;
                    }
                }
            }

            return second;
        }
    }
}
