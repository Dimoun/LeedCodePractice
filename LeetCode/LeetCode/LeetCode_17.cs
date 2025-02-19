using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class LeetCode_17
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> res = new List<string>();

            IList<string> list = new List<string>();
            if (string.IsNullOrEmpty(digits))
                return res;
            int len = digits.Length;
            int index = 0;
            for (int i = 0; i < len; i++)
            {
                string str = digits[i] switch 
                {
                     '2' => "abc",
                     '3' => "def",
                     '4' => "ghi",
                     '5' => "jkl",
                     '6' => "mno",
                     '7' => "pqrs",
                     '8' => "tuv",
                     '9' => "wxyz",
                };
                if (!string.IsNullOrEmpty(str))
                {
                    list.Add(str);
                }
            }

            BackTracking(len, 0, "", list, res);
            return res;
        }

        public void BackTracking(int len,int startIndex, string sb,IList<string> list,IList<string> res)
        {
            if (sb.Length == len)
            {
                res.Add(new string(sb));
                return;
            }

            for (int i = startIndex; i < len; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    sb += list[i][j];
                    BackTracking(len,i+1,sb,list,res);
                    sb = sb.Substring(0,sb.Length-1);
                }
            }
        }
    }
}
