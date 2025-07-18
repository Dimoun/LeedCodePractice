using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.Hash
{
    public class Hash
    {
        public bool LeetCode_242_IsAnagram(string s, string t)
        {
            //medhod1 HashTable
            //Dictionary<char,int> dic = new Dictionary<char,int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (dic.ContainsKey(s[i]))
            //    {
            //        dic[s[i]]++;
            //    }
            //    else
            //    {
            //        dic.Add(s[i],1);
            //    }
            //}

            //for (int i = 0; i < t.Length; i++)
            //{
            //    if (dic.ContainsKey(t[i]))
            //    {
            //        dic[t[i]]--;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //foreach (var item in dic)
            //{
            //    if (item.Value != 0)
            //    {
            //        return false;
            //    } 
            //}
            //return  true;

            //Method2 数组

            int len1 = s.Length;
            int len2 = t.Length;
            if (len1 != len2) return false;
            int[] arr = new int[26];
            for (int i = 0; i < len1; i++)
            {
                arr[s[i] - 'a']++;
                arr[t[i] - 'a']--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
        public int[] LeetCode_349_Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            HashSet<int> res = new HashSet<int>();  
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!dic.ContainsKey(nums1[i]))
                {
                    dic.Add(nums1[i],1);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (dic.ContainsKey(nums2[i]))
                {
                    res.Add(nums2[i]);
                }
            }

            return res.ToArray();
        }
        public bool LeetCode_202_IsHappy(int n)
        { 
            HashSet<int> set = new HashSet<int>();
            while (n != 1 && !set.Contains(n))
            {
                set.Add(n);
                int sum = 0;
                while (n > 0)
                {
                    sum += (n % 10) * (n % 10);
                    n = n / 10;
                }

                n = sum;
            }

            return n == 1;
        }
        public int[] LeetCode_1_TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int offset = target - nums[i];
                if (dic.ContainsKey(offset))
                {
                    return new int[] { dic[offset], i };
                }

                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i],i);
                }
            }
            return null;
        }
        public int LeetCode_454_FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    int sum = nums1[i] + nums2[j];
                    if (dic.ContainsKey(sum))
                    {
                        dic[sum]++;
                    }
                    else
                    {
                        dic.Add(sum, 1);
                    }
                }
            }

            int res = 0;
            for (int i = 0; i < nums3.Length; i++)
            {
                for (int j = 0; j < nums4.Length; j++)
                {
                    int sum = 0 - (nums3[i] + nums4[j]);
                    if (dic.ContainsKey(sum))
                    {
                        res += dic[sum];
                    }
                }
            }

            return res;
        }

        public bool LeetCode_383_CanConstruct(string ransomNote, string magazine)
        {
            //Method1 
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                if (dic.ContainsKey(magazine[i]))
                {
                    dic[magazine[i]]++;
                }
                else
                {
                    dic.Add(magazine[i],1);
                }
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (dic.ContainsKey(ransomNote[i]) && dic[ransomNote[i]] > 0)
                {
                    dic[ransomNote[i]]--;
                }
                else
                {
                    return false;
                }
            }

            return true;


            //Method2 数组
            int[] freq = new int[26];

            foreach (var m in magazine)
            {
                freq[m - 'a']++;
            }

            foreach (var r in ransomNote)
            {
                if (freq[r - 'a'] <= 0)
                    return false;
                freq[r - 'a']--;
            }
            return true;
        }
        public IList<IList<int>> LeetCode_15_ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();

            int len = nums.Length;
            for (int i = 0; i < len-2; i++)
            {
                if (nums[i] > 0) return res;
                int n1 = nums[i];

                if (i>0 && nums[i] == nums[i-1]) 
                    continue;
                int left = i+1, right = len - 1;
                while (left < right)
                {
                    int n2 = nums[left];
                    int n3 = nums[right];
                    int sum = n1 + n2 + n3;
                    if (sum > 0)
                    {
                        right--;
                    }
                    else if(sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                       res.Add(new List<int>() { nums[i], nums[left], nums[right] });
                       while (left < right && nums[left] == n2)
                       {
                           left++;
                       }

                       while (left < right && nums[right] == n3)
                       {
                           right--;
                       }
                    }
                }
            }

            return res;
        }

        public IList<IList<int>> LeetCode_18_FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            int len = nums.Length;

            for (int i = 0; i < len - 3; i++)
            {
                // 剪枝优化（仅在 nums[i] 非负时有效）
                if (nums[i] > 0 && nums[i] > target)
                    break;
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int n1 = nums[i];

                for (int j = i+1; j < len-2; j++)
                {
                    if (j > i+1 && nums[j] == nums[j - 1])
                        continue;
                    int n2 = nums[j];

                    int left = j + 1, right = len - 1;
                    while (left < right)
                    {
                        int n3 = nums[left];
                        int n4 = nums[right];
                        long sum = (long)n1 + n2 + n3+n4;
                        if (sum > target)
                        {
                            right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            res.Add(new List<int>() { n1,n2,n3,n4 });
                            while (left < right && nums[left] == n3)
                            {
                                left++;
                            }

                            while (left < right && nums[right] == n4)
                            {
                                right--;
                            }
                        }
                    }
                }
            }

            return res;
        }
    }
}
