using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.InterviewQ
{
    public class Interview_16_15
    {
        public int[] MasterMind(string solution, string guess)
        {
            int count = 0;
            int num = 0;
            Dictionary<char,int> dic = new Dictionary<char, int>();
            Dictionary<char, int> dc = new Dictionary<char, int>();

            for (int i= 0; i < solution.Length; i++)
            {
                if(solution[i] == guess[i])
                {
                    count++;
                }
                else
                {
                    if(dic.ContainsKey(guess[i])&& dic[guess[i]]<=0)
                    {
                        dic.Remove(guess[i]);
                        num++;
                    }
                    else
                    {
                        if (!dc.ContainsKey(guess[i]))
                        {
                            dc.Add(guess[i], 0);
                        }
                        else {
                            dc[guess[i]]++;
                        }
                    }


                    if (dc.ContainsKey(solution[i]) && dc[solution[i]]<=0)
                    {
                        dc.Remove(solution[i]);
                        num++;
                    }
                    else
                    {
                        if (!dic.ContainsKey(solution[i]))
                        {
                            dic.Add(solution[i], 0);
                        }
                        else
                        {
                            dic[solution[i]]++;
                        }
                    }
                }
            }
            return new int[] { count,num};
        }
    }
}
