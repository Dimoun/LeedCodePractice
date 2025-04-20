using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
    public class LeetCode_697
    {
        public int FindShortestSubArray(int[] nums)
        {
            //建立哈希表，key是原数组中的数，value为一个大小为3的数组，
            //三个值分别代表出现次数，第一次出现的索引，最后一次出现的索引

            Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]][0]++;
                    dictionary[nums[i]][2] = i;
                }
                else
                {
                    dictionary.Add(nums[i], new int[3] { 1, i, i });
                }
            }
            int minLength = 0;
            int maxNumber = 0;
            foreach (var pair in dictionary)
            {
                if (pair.Value[0] > maxNumber)
                {
                    maxNumber = pair.Value[0];
                    minLength = pair.Value[2] - pair.Value[1];
                }
                else if (pair.Value[0] == maxNumber)
                {
                    if (minLength > pair.Value[2] - pair.Value[1])
                    {
                        minLength = pair.Value[2] - pair.Value[1];
                    }
                }
            }


            return minLength + 1;
        }
    }
}
