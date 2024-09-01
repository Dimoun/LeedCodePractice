using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ1
    {
        public int GetLastWordLength(string str) {

            string[] arr  = str.Split(" ");

            return arr[arr.Length -1].Length;
        }

    }
}
