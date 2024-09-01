using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ5
    {
        public int ConverHexToDecimal(string input)
        {
           int value = Convert.ToInt32(input,16);
           System.Console.WriteLine(value);
           return value;
        }
    }
}
