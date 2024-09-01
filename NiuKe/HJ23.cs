using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ23
    {
        public void Method()
        {
            string line;
            while ((line = System.Console.ReadLine()) != null)
            {
                int min = int.MinValue;
                int len = line.Length;
                Dictionary<char, int> dic = new Dictionary<char, int>();

               for(int i = 0; i < len; i++)
                {
                    if (dic.ContainsKey(line[i]))
                    {
                        dic[line[i]]++;
                    }
                    else
                    {
                        dic.Add(line[i], 1);
                    }
                }
                min = dic.Values.Min();
                var keys = dic.Where(x => x.Value == min).Select(x => x.Key);
                //var list = line.ToList();

                ////
                //list = list.Where(x => !keys.Contains(x)).ToList();
                //


                foreach (var key in keys)
                {
                    while (line.Contains(key))
                    {
                        line = line.Remove(line.IndexOf(key),1);
                    }
                }
                System.Console.WriteLine(string.Concat(line));
            }
        }
    }
}
