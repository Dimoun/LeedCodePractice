using System;
using System.Collections.Generic;

namespace NiuKe
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet<int> set = new HashSet<int>();
            //string line;
            //while ((line = System.Console.ReadLine()) != null)
            //{ // 注意 while 处理多个 case

            //    int len = line.Length;
            //    for (int i = 0; i < len; i++)
            //    {
            //        if (!set.Contains(line[i]))
            //        {
            //            set.Add(line[i]);
            //        }
            //    }
            //}
            //System.Console.WriteLine(set.Count);


            //HashSet<int> set = new HashSet<int>();
            //int n= 0;
            //string line;
            //while ((line = System.Console.ReadLine()) != null)
            //{ // 注意 while 处理多个 case
            //    string[] tokens = line.Split();
            //    if (n == 0)
            //    {
            //        n++;
            //        continue;
            //    }
            //    else { 
            //       set.Add(int.Parse(tokens[0]));
            //    }
            //    //System.Console.WriteLine(tokens[tokens.Length - 1].Length);
            //}

            // HJ1 hj1 = new HJ1();
            //int len = hj1.GetLastWordLength("hello nowcoder");
            //NC61 nc = new NC61();
            //int[] arr = { 3,2,4 };
            //nc.TwoSum(arr, 6);

            //HJ17 hj = new HJ17();
            HJ8 hj = new HJ8();
            hj.Method();
        }
    }
}
