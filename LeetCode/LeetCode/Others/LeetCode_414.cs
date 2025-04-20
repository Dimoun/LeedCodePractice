using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    public class LeetCode_414
    {
        public int ThirdMax(int[] nums)
        {
            //Method 1
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            int first = int.MinValue;
            int sec = int.MinValue;
            int third = int.MinValue;
            first = nums[nums.Length - 1];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != first)
                {
                    if (sec == int.MinValue)
                    {
                        sec = nums[i];
                    }
                    if (nums[i] != sec)
                    {
                        if (third == int.MinValue)
                        {
                            third = nums[i];
                            return third;
                        }
                    }
                }
            }

            return first;


            //Methtod 2

            SortedSet<int> s = new SortedSet<int>();
            foreach (int i in nums)
            {
                s.Add(i);
                if (s.Count > 3)
                {
                    s.Remove(s.Min);
                }
            }
            return s.Count == 3 ? s.Min : s.Max;
        }
    }
}
