using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

public class Classics_49 {

    // 输入: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
    // 输出: [["bat"],["nat","tan"],["ate","eat","tea"]]

    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        //Method1: 有问题，未考虑单词有重复字母
        IList<IList<string>> res = new List<IList<string>>();
        Dictionary<string,int> dic = new Dictionary<string, int>();
        int len = strs.Length;

        foreach(string item in strs){
            if(!dic.ContainsKey(item)){
                dic.Add(item,1);
            }
            else
            {
                dic[item]++;
            }
        }

        for(int i=0; i<len; i++)
        {
            if(dic[strs[i]] == 0) continue;

            IList<string> list = new List<string>();
            if (strs[i] == "")
            {
                while (dic[strs[i]] > 0)
                {
                    list.Add(strs[i]);
                    dic[strs[i]]--;
                }
            }
            else
            {
                list.Add(strs[i]);
                dic[strs[i]]--;
            }

            HashSet<char> hashSet = new HashSet<char>();
            
            for(int j=0; j<strs[i].Length; j++)
            {
                if(!hashSet.Contains(strs[i][j])){
                    hashSet.Add(strs[i][j]);
                }   
            }
            int count = hashSet.Count;
            for(int k=i+1; k<len; k++){
                if((count != strs[k].Length))
                {
                    continue;
                }else{
                    for(int m = 0; m<strs[k].Length; m++){
                        if(hashSet.Contains(strs[k][m]))
                        {
                            if (m == strs[k].Length - 1)
                            {
                                list.Add(strs[k]);
                                dic[strs[k]]--;
                            }
                        }
                        else{
                            break;
                        }
                    }
                }
            }
            res.Add(list);

        }

        return res;
    }

    public IList<IList<string>> Method(string[] strs)
    {
        Dictionary<string, List<string>> dic = [];
        foreach (string item in strs)
        {
            string str = new string(item.Order().ToArray());
            dic.TryAdd(str, new List<string>());
            dic[str].Add(item);
        }

        //IDictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
        //foreach (string str in strs)
        //{
        //    char[] array = str.ToCharArray();
        //    Array.Sort(array);
        //    string key = new string(array);
        //    dictionary.TryAdd(key, new List<string>());
        //    dictionary[key].Add(str);
        //}
        return new List<IList<string>>(dic.Values);
    }
}