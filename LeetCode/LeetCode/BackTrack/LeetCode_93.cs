using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.BackTrack
{
    public class LeetCode_93
    {
        private IList<string> res = new List<string>();
        private IList<string> path = new List<string>();
        public IList<string> RestoreIpAddresses(string s)
        {
            BackTracking(0, s);
            return res;
        }

        public void BackTracking(int startIndex, string s)
        {
            int pathCount = path.Count, strLength = s.Length;
            if (pathCount == 4 && startIndex == strLength)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 4; i++)
                {
                    sb.Append(path[i]);
                    if (i != 3)
                    {
                        sb.Append(".");
                    }
                }
                res.Add(sb.ToString());
                return;
            }
            for (int i = startIndex; i < strLength && pathCount < 4; i++)
            {
                string str = s.Substring(startIndex, i - startIndex + 1);
                if (str.StartsWith("0") && str.Length != 1 || str.Length > 3)
                {
                    return;
                }
                else
                {
                    int num = int.Parse(str);
                    if (num > 255)
                        return;
                }

                path.Add(str);
                BackTracking(i + 1, s);
                path.RemoveAt(path.Count - 1);

            }
        }
    }
}
