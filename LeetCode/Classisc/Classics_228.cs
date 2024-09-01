using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_228
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<String> list = new List<string>();
            if (nums == null||nums.Length == 0)
            {
                return list;
            }
            int i = 0;
            int begin = 0;
            int count = 0;
            while (i < nums.Length-1)
            {
                if(nums[i]+1 == nums[i+1])
                {
                    if(count == 0)
                    {
                        begin = i;
                    }
                    count++;
                }
                else
                {
                    if(count == 0)
                    {
                        list.Add(nums[i].ToString());
                    }
                    else
                    {
                        list.Add(nums[begin]+"->"+nums[begin+count]);
                    }
                    begin = 0;
                    count = 0;
                }
                i++;
            }
            if(count == 0)
            {
                list.Add(nums[i].ToString());
            }
            else
            {
                list.Add(nums[begin] + "->" + nums[begin + count]);
            }

            return list ;
        }
    }
}
