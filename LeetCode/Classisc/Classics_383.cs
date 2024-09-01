using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Classics_383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {

            //Method 1
            int[] arr = new int[26];

            for(int i = 0; i < magazine.Length; i++)
            {
                arr[magazine[i] - 'a']++;
            }
            for(int i = 0; i < ransomNote.Length; i++)
            {
                arr[ransomNote[i] - 'a']--;

                if(arr[ransomNote[i] - 'a'] < 0)
                {
                    return false;
                }

            }

            return true;


            //Mehtod 2
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for(int i = 0; i < magazine.Length; i++)
            {
                if (dic.ContainsKey(magazine[i]))
                {
                    dic[magazine[i]]++;
                }
                else
                {
                    dic.Add(magazine[i], 1);
                }
            }
            for(int i= 0; i < ransomNote.Length; i++)
            {
                if (dic.ContainsKey(ransomNote[i]) && dic[ransomNote[i]]>0){
                    dic[ransomNote[i]]--;
                }
                else
                {
                    return false;
                }
            }
            return true;


        }
    }
}
