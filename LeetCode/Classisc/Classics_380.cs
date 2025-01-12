using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_380
    {
        private Dictionary<int, int> dic;
        private Random random;
        private List<int> list;

        public Classics_380()
        {
            dic = new Dictionary<int, int>();
            list = new List<int>();
            random = new Random();
        }

        public bool Insert(int val)
        {
            if (dic.ContainsKey(val))
            {
                return false;
            }

            int index = dic.Count;
            dic.Add(val,index);
            list.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (!dic.ContainsKey(val))
            {
                return false;
            }
            dic.Remove(val);
            list.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            int index = random.Next(dic.Count);
            return list[index];
        }
    }

}
