using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ101
    {
        public void Method()
        {
            string num = System.Console.ReadLine();
            string str = System.Console.ReadLine();
            string ori = System.Console.ReadLine();

            string[] strArr = str.Split(' ');
            if (ori == "0")
            {
                UpSort(strArr);
            }
            else if(ori == "1"){
                DownSort(strArr);
            }
        }

        public void UpSort(string[] str)
        {
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if(int.Parse(str[i]) > int.Parse(str[j]))
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                System.Console.Write(str[i] + " ");
            }
        }
        public void DownSort(string[] str)
        {
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (int.Parse(str[i]) < int.Parse(str[j]))
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
            for(int i = 0; i < len; i++)
            {
                System.Console.Write(str[i]+" ");
            }

        }
    }
}
