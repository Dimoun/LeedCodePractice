using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_13
    {
        public int RomanToInt(string s)
        {
            int num = 0;
            char pre= ' ';
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0)
                {
                    pre = s[i - 1];
                }
                if (s[i] == 'I')
                {
                    num += 1;
                }
                else if (s[i] == 'V')
                {
                    if (pre != 'I')
                    {
                        num += 5;
                    }
                    else
                    {
                        num += 3;
                    }
                }
                else if (s[i] == 'X')
                {
                    if (pre != 'I')
                    {
                        num += 10;
                    }
                    else
                    {
                        num += 8;
                    }
                }
                else if (s[i] == 'L')
                {
                    if (pre != 'X')
                    {
                        num += 50;
                    }
                    else
                    {
                        num += 30;
                    }
                }
                else if (s[i] == 'C')
                {
                    if (pre != 'X')
                    {
                        num += 100;
                    }
                    else
                    {
                        num += 80;
                    }
                }
                else if (s[i] == 'D')
                {
                    if (pre != 'C')
                    {
                        num += 500;
                    }
                    else
                    {
                        num += 300;
                    }
                }
                else if (s[i] == 'M')
                {
                    if (pre != 'C')
                    {
                        num += 1000;
                    }
                    else
                    {
                        num += 800;
                    }
                }
            }

            return num;
        } 
    }
}
