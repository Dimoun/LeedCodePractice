using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ33
    {
        public void Method()
        {
            string line;
            while ((line = System.Console.ReadLine()) != null)
            { // 注意 while 处理多个 case
                string[] tokens = line.Split('.');
                int len = tokens.Length;
                if (len == 4)
                {
                    IPConverToNum(tokens);
                }
                else if (len == 1)
                {
                    NumConverToIP(line);
                }
            }
        }
        public void NumConverToIP(string num)
        {
            string number = Convert.ToString(Int64.Parse(num), 2).PadLeft(32,'0');
            string[] str = new string[4];
            string res = string.Empty;
            for(int i = 0; i < 4; i++)
            {
                str[i] = number.Substring(i*8, 8);
                str[i] = Convert.ToInt32(str[i], 2).ToString();
            }
            res = string.Join('.', str);
            System.Console.WriteLine(res);

        }
        public void IPConverToNum(string[] tokens)
        {
            string[] arr = new string[4];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(Convert.ToString(int.Parse(tokens[i]), 2).PadLeft(8,'0'));
            }

            long res = Convert.ToInt64(sb.ToString(),2);
            System.Console.WriteLine(res);
        }
    }
}
