using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ20
    {
        public void Method()
        {
            string line;
            while ((line = System.Console.ReadLine()) != null)
            { // 注意 while 处理多个 case
                int len = line.Length;
                if (len <= 8)
                {
                    System.Console.WriteLine("NG");
                    continue;
                }
                int num = 0;

                int digit = 0;
                int lowercase = 0;
                int majuscule = 0;
                int other = 0;
                for (int i = 0; i < len; i++)
                {
                    char ch = line[i];
                    if (ch >= '0' && ch <= '9')
                    {
                        if(digit == 0)
                        {
                            num++;
                            digit = 1;
                        }
                    }
                    else if(ch >= 'A' && ch <= 'Z')
                    {
                        if(majuscule == 0)
                        {
                            num++;
                            majuscule = 1;
                        }
                    }
                    else if (ch >='a' && ch <= 'z')
                    {
                        if (lowercase == 0)
                        {
                            num++;
                            lowercase = 1;
                        }
                    }
                    else
                    {
                        if(other == 0)
                        {
                            num++;
                            other = 1;
                        }
                    }
                }
                if(num < 3)
                {
                    System.Console.WriteLine("NG");
                    continue;
                }
               
                bool res = true;
                for (int i = 3; i < len; i++)
                {
                    string substring = line.Substring(i-3, 3);
                    if (line.Substring(i).Contains(substring))
                    {
                        System.Console.WriteLine("NG");
                        res = false;
                        break;
                    }
                }
                if (res)
                {
                    System.Console.WriteLine("OK");
                }
            }
        }
    }
}
