﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    public class LeetCode_191
    {
        public int HammingWeight(uint n)
        {
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                {
                    res++;
                }
                n = n >> 1;
            }

            return 0;
        }

    }
}
