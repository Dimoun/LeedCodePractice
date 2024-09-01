using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    class Classics_125
    {
        public bool IsPalindrome(string s)
        {
            if (s == " ")
                return true;

            StringBuilder stringBuilder = new StringBuilder();
            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] bytes = ascii.GetBytes(s);

            for (int i = 0; i < bytes.Length; i++)
            {
                if ((bytes[i] >= 48 && bytes[i] <= 57) || (bytes[i] >= 97 && bytes[i]<=122) || (bytes[i]>=65 && bytes[i] <= 90))
                {
                    if(bytes[i] >= 65 && bytes[i] <= 90)
                    {
                        stringBuilder.Append((char)(bytes[i]+32));
                    }
                    else
                    {
                        stringBuilder.Append((char)bytes[i]);
                    }
                }
            }


            string str = stringBuilder.ToString();
            int len = str.Length;
            int num = len / 2;
            int remainder = len % 2;
            int begin=0, end = str.Length-1;
            while (begin <= end)
            {
                if (str[begin] != str[end])
                {
                    return false;
                }
                begin++;
                end--;
            }
  
            return true;
        }
    }
}
