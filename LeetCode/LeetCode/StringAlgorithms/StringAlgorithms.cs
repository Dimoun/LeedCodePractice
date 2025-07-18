using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.StringAlgorithms
{
    public class StringAlgorithms
    {
        public void LeetCode_344_ReverseString(char[] s)
        {
            //Method1 
            //int i = 0, j = s.Length - 1;
            //while (i<j)
            //{
            //    var temp = s[i];
            //    s[i] = s[j];
            //    s[j] = temp;
            //    i++;
            //    j--;
            //}
            //Method2 元组
            for (int i = 0,j=s.Length-1; i<j; i++,j--)
            {
                (s[i], s[j]) = (s[j], s[i]);
            }
        }
        public string LeetCode_541_ReverseStr(string s, int k)
        {
            char[] res = s.ToCharArray();

            for (int i = 0; i < s.Length; i += 2*k)
            {
                int left = i;
                int right = Math.Min(i + k - 1, s.Length - 1);

                while (left < right)
                {
                    char temp = res[left];
                    res[left] = res[right];
                    res[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(res);
        }

        public string LeetCode_151_ReverseWords(string s)
        {
            var str = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = 0,j = str.Length-1; i < j; i++,j--)
            {
                string temp = str[i];
                str[i] = str[j];
                str[j] = temp;
            }

            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(str[i]);
                if (i != str.Length - 1)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }

        public int LeetCode_28_StrStr(string haystack, string needle)
        {
            int res = -1;
            int n = haystack.Length, m = needle.Length;

            for (int i = 0; i + m <= n; i++)
            {
                bool match = true;

                for (int j = 0; j < m && match; j++)
                {
                    if (haystack[i+j] != needle[j])
                    {
                        match = false;
                    }
                }

                if (match)
                {
                    return i;
                }
            }

            return -1;
        }
        public bool LeetCode_459_RepeatedSubstringPattern(string s)
        {
            string ss = (s + s).Substring(1, (s + s).Length - 2);
            return ss.Contains(s);
        }
    }
}
