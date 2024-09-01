using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_290
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] str = s.Split(" ");
            Dictionary<char,string> dic = new Dictionary<char, string>();
            string key;
            if (pattern.Length != str.Length)
                return false;
            for(int i = 0; i < pattern.Length; i++)
            {
                if (dic.ContainsKey(pattern[i]))
                {
                    if(dic[pattern[i]] != str[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dic.ContainsValue(str[i]))
                    {
                        return false;
                    }
                    dic.Add(pattern[i], str[i]);
                }
            }
            return true; ;
        }
    }
}
