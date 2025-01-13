using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_28
    {
        public int StrStr(string haystack, string needle)
        {
            if (!haystack.Contains(needle))
                return -1;

            int hayLen = haystack.Length;
            int needLen = needle.Length;

            for (int i = 0; i + needLen <= hayLen; i++)
            {
                bool flag = true;
                if (haystack[i] == needle[0])
                {
                    for (int j = 0; j < needLen; j++)
                    {
                        if (haystack[i+j] != needle[j])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
