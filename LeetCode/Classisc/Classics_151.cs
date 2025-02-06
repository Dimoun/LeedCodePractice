using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_151
    {
        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            string[] str = s.Split(" ");
            int len = str.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                if (str[i] != "")
                {
                    sb.Append(str[i]).Append(" ");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
