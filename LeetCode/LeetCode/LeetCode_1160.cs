using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_1160
    {
        public int CountCharacters(string[] words, string chars)
        {
            //Method 1: 内存消耗过大
            int num = 0;
            int totalLength = 0;
            string str = null;
            for (int i = 0; i < words.Length; i++)
            {
                str = chars;
                num = 0;
                if (words[i].Length > chars.Length)
                {
                    continue;
                }
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (str.Contains(words[i][j]))
                    {
                        str = str.Remove(str.IndexOf(words[i][j]), 1);
                        num++;
                    }
                    if (num == words[i].Length)
                    {
                        totalLength += num;
                    }
                }
            }

            return totalLength;

            //Method 2
            var ch = chars.ToCharArray();
            Array.Sort(ch);
            int re = 0;
            foreach (var word in words)
            {
                int a = 0, b = 0;
                var wo = word.ToCharArray();
                Array.Sort(wo);
                if(wo.Length > ch.Length)
                {
                    continue;
                }
                while (a < wo.Length && b < ch.Length)
                {
                    if (wo[a] == ch[b])
                    {
                        a++;
                        b++;
                        if (a == wo.Length)
                        {
                            re += word.Length;
                        }
                    }
                    else
                    {
                        b++;
                        if (b == chars.Length || ch[b] > wo[a])
                        {
                            break;
                        }
                    }
                }

            }
            return re;
        }
    }
}
