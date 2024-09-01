using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ8
    {
        public void Method()
        {
            string line;
            int num = int.Parse(System.Console.ReadLine());
            int temp = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            while ((line = System.Console.ReadLine()) != null && temp<num)
            {
                string[] tokens = line.Split();
                int key = int.Parse(tokens[0]);
                int value = int.Parse(tokens[1]);
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, value);
                }
                else
                {
                    dic[key] += value;
                }
                temp++;
            }
            var sortdic = dic.OrderBy(x => x.Key);
            foreach(var item in sortdic)
            {
                System.Console.WriteLine(item.Key+" "+ item.Value);
            }
        }
    }
}
