﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    public class LeetCode_70
    {
        public int ClimbStairs(int n)
        {
            int sum = 0;
            if (n == 1 || n == 2)
            {
                return n;
            }
            int[] arr = new int[n];
            arr[0] = 1;
            arr[1] = 2;
            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n - 1];
        }
    }
}
