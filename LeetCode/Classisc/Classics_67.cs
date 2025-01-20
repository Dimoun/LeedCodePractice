using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_67
    {
        public string AddBinary(string a, string b)
        {
            long num1 = Convert.ToInt64(a, 2);
            long num2 = Convert.ToInt64(b, 2);
            long res = num1 + num2;
            return Convert.ToString(res, 2);
        }

    }
}
