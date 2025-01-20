using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_66
    {
        public int[] PlusOne(int[] digits)
        {
            
            int len = digits.Length;
            int last = digits[len-1];

            for (int i = len-1; i >= 0 ; i--)
            {
                digits[i] = ++digits[i] % 10;
                if (digits[i] != 0)
                {
                    return digits;
                }
            }

            digits = new int[len + 1];
            digits[0] = 1;

            return digits;
        }
    }
}
