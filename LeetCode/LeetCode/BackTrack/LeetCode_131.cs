using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.BackTrack
{
    public class LeetCode_131
    {
        IList<IList<string>> res = new List<IList<string>>();
        List<string> path = new List<string>();

        public IList<IList<string>> Partition(string s)
        {
            BackTracking(0, s);
            return res;
        }

        public void BackTracking(int startIndex, string str)
        {
            if (startIndex == str.Length)
            {
                res.Add(new List<string>(path));
                return;
            }

            for (int i = startIndex; i < str.Length; i++)
            {
                string s = str.Substring(startIndex, i - startIndex + 1);
                if (IsPalindrome(s))
                {
                    path.Add(s);
                }
                else
                {
                    continue;
                }
                BackTracking(i + 1, str);
                path.RemoveAt(path.Count - 1);
            }
        }
        public bool IsPalindrome(string str)
        {
            int len = str.Length;
            for (int i = 0, j = len - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
