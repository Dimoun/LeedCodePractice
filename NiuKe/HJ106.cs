using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ106
    {
        public void Method()
        {
            string line;
            while ((line = System.Console.ReadLine()) != null)
            { 
                StringBuilder sb = new StringBuilder(line);
                int len = line.Length;
                for (int i = 0, j = len - 1; i < j; i++, j--)
                {
                    char temp = sb[i];
                    sb[i] = line[j];
                    sb[j] = temp;
                }
                for (int i = 0; i < len; i++)
                {
                    System.Console.Write(sb[i]);
                }
            }
        }
    }
}
