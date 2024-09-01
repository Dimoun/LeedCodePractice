using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ17
    {
        public void method()
        {
            string line;
            while ((line = System.Console.ReadLine()) != null)
            { 
                string[] tokens = line.Split(';');
                int len = tokens.Length;
                int left = 0,up = 0;
                for (int i = 0; i < len; i++) {
                    string str = tokens[i];
                    if(str.Length <= 3 && str.Length>=2)
                    {
                        char ch = str[0];
                        if (ch=='A'||ch=='D'||ch=='W'||ch=='S')
                        {

                            string sub = str.Substring(1);
                            int num;
                            bool res = int.TryParse(sub, out num);

                            switch (ch)
                            {
                                case 'A':
                                    left -= num;
                                    break;
                                case 'D':
                                    left += num;
                                    break;
                                case 'W':
                                    up += num;
                                    break;
                                case 'S':
                                    up -= num;
                                    break;

                            }
                        }
         
                    }
                }
                System.Console.Write(left);
                System.Console.Write(",");
                System.Console.Write(up);

            }
        }
    }
}
