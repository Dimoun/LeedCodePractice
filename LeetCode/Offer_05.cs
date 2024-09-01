using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Offer_05
    {
        public string ReplaceSpace(string s)
        {
            //Method 1
            s = s.Replace(" ", "%20");
            
            
            //Method 2

            //StringBuilder stringBuilder = new StringBuilder();
            //char[] ch = s.ToCharArray();
            //for (int i = 0; i < ch.Length; i++)
            //{
            //    if (ch[i] == ' ')
            //    {
            //        stringBuilder.Append("%20");
            //    }
            //    else
            //    {
            //        stringBuilder.Append(ch[i]);
            //    }
            //}
            return s;
        }
    }
}
