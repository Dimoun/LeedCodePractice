using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Classics_392
    {
        public bool IsSubsequence(string s, string t)
        {
            //Method 1
            //if (s == "")
            //{
            //    return true;
            //}
            //int num = 0;
            //int j = 0;
            //for( int i = 0; i < s.Length; i++)
            //{
            //    while (j < t.Length) 
            //    {
            //        if(s[i] == t[j])
            //        {
            //            if (i == s.Length - 1)
            //            {
            //                return true;
            //            }
            //            num = j;
            //            j++;
            //            break;
            //        }
            //        j++;
            //    }
            //}
            //return false;

            //Method 2 双指针
            int n = 0, m = 0;
            while (n < s.Length && m < t.Length)
            {
                if(s[n] == t[m])
                {
                    if (n == s.Length - 1)
                    {
                        return true;
                    }
                    n++;
                }
                m++;
            }
            return false;

        }
    }
}
