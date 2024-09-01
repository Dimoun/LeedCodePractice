using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_205
    {

        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char,char> dic = new Dictionary<char,char>();

            for(int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if(dic[s[i]] == t[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (dic.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dic.Add(s[i], t[i]);
                    }
                }
            }

            return true;
        }

    }
}
