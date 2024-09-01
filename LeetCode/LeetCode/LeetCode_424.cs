using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_424
    {
        public int CharacterReplacement(string s, int k)
        {
            int first = 0;
            int end = 0;
            int max = 0;
            int index = 0;
            char[] arr = s.ToArray();
            int[] number = new int[26];
            while (end < s.Length)
            {
                index = arr[end] - 'A';
                number[index]++;
                max = Math.Max(max, number[index]);
                if (end - first + 1 > max + k)
                {
                    number[arr[first] - 'A']--;
                    first++;
                }
                end++;
            }


            return end-first;
        }
    }
}
