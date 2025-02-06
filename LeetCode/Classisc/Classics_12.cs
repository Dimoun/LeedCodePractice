using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_12
    {
        public string IntToRoman(int num)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            String[] rom = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder sb = new StringBuilder();
            int len = values.Length;
            for(int i = 0; i < len; i++)
            {
                while (num >= values[i])
                {
                    num -= values[i];
                    sb.Append(rom[i]);
                }
            }

            return sb.ToString();

        }
    }
}
