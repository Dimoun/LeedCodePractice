using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Others;

namespace LeetCode.Greedy
{
    public class Greedy
    {
        public int LeetCode_122_MaxProfit(int[] prices)
        {
            int res = 0;
            int len = prices.Length;

            for (int i = 1; i < len; i++)
            {
                res += Math.Max(prices[i] - prices[i - 1], 0);
            }

            return res;
        }
        public bool LeetCode_55_CanJump(int[] nums)
        {
            int len = nums.Length;

            if (len == 1)
                return true;
            int cover = 0;

            for (int j = 0; j <= cover; j++)
            {
                cover = Math.Max(nums[j] + j, cover);
                if (cover >= len - 1)
                {
                    return true;
                }
            }
            return false;
        }

        public int LeetCode_45_Jump(int[] nums)
        {
            int cur = 0, step = 0, next = 0;
            int len = nums.Length;
            for (int i = 0; i < len - 1; i++)
            {
                next = Math.Max(next, nums[i] + i);
                if (i == cur)
                {
                    step++;
                    cur = next;
                }
            }

            return step;
        }
        public int LeetCode_1005_LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums, (a, b) => Math.Abs(a) - Math.Abs(b));
            int len = nums.Length;
            int count = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                if (nums[i] < 0 && k > 0)
                {
                    nums[i] = -nums[i];
                    k--;
                }
            }

            if (k % 2 == 1)
            {
                nums[0] = -nums[0];
            }

            foreach (var value in nums)
            {
                count += value;
            }
            return count;
        }
        public int LeetCode_134_CanCompleteCircuit(int[] gas, int[] cost)
        {
            int curSum = 0, totalSum = 0, index = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                curSum += gas[i] - cost[i];
                totalSum += gas[i] - cost[i];
                if (curSum < 0)
                {
                    index = i + 1;
                    curSum = 0;
                }
            }

            if (totalSum < 0)
                return -1;
            return index;
        }
        public bool LeetCode_860_LemonadeChange(int[] bills)
        {
            int five = 0, ten = 0;
            foreach (var item in bills)
            {
                switch (item)
                {
                    case 5:
                        five++;
                        break;
                    case 10:
                        if (five <= 0)
                            return false;
                        ten++;
                        five--;
                        break;
                    case 20:
                        if (five > 0 && ten > 0)
                        {
                            five--;
                            ten--;
                        }
                        else if (five >= 3)
                        {
                            five -= 3;
                        }
                        else return false;

                        break;
                }
            }

            return true;
        }

        public int[][] LeetCode_406_ReconstructQueue(int[][] people)
        {
            Array.Sort(people, (a, b) =>
            {
                if (a[0] == b[0])
                {
                    return a[1] - b[1];
                }

                return b[0] - a[0];
            });

            List<int[]> list = new List<int[]>();
            for (int i = 0; i < people.Length; i++)
            {
                list.Insert(people[i][1], people[i]);
            }

            return list.ToArray();
        }
        public int LeetCode_452_FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (a, b) =>
            {
                if (a[0] < b[0])
                {
                    return -1;
                }

                return a[0] > b[0] ? 1 : 0;
            });
            int res = 0;
            int[] temp = points[0];
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i][0] > temp[1])
                {
                    res++;
                    temp = points[i];
                }
                else
                {
                    temp[1] = Math.Min(temp[1], points[i][1]);
                }
            }
            return res + 1;
        }
        public int LeetCode_435_EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) =>
            {
                if (a[0] < b[0])
                {
                    return -1;
                }

                return a[0] > b[0] ? 1 : 0;
            });

            int res = 0;
            int end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (end > intervals[i][0])
                {
                    res++;
                    end = Math.Min(end, intervals[i][1]);
                }
                else
                {
                    end = intervals[i][1];
                }
            }

            return res;
        }

        public IList<int> LeetCode_763_PartitionLabels(string s)
        {
            //Method 1
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            IList<int> res = new List<int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (dic.ContainsKey(s[i]))
            //    {
            //        dic[s[i]] = Math.Max(dic[s[i]], i);
            //    }
            //    else
            //    {
            //        dic.Add(s[i],i);
            //    }
            //}

            //int count = 0;
            //int index = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    index = Math.Max(dic[s[i]], index);
            //    if (i == index)
            //    { 
            //        count++;
            //        res.Add(count);
            //        count = 0;
            //    }
            //    else
            //    {
            //        count++;
            //    }
            //}

            //return res;


            //Method 2

            int[] location = new int[27];
            for (int i = 0; i < s.Length; i++)
            {
                location[s[i] - 'a'] = i;
            }

            int index = 0;
            int left = 0;
            for (int i = 0; i < s.Length; i++)
            {
                index = Math.Max(index, location[s[i] - 'a']);
                if (i == index)
                {
                    res.Add(index - left + 1);
                    left = i + 1;
                }
            }

            return res;
        }
        public int LeetCode_738_MonotoneIncreasingDigits(int n)
        {
            char[] str = n.ToString().ToCharArray();
            int index = str.Length;
            for (int i = str.Length - 1; i > 0; i--)
            {
                if (str[i] < str[i - 1])
                {
                    str[i - 1]--;
                    index = i;
                }
            }

            for (int i = index; i < str.Length; i++)
            {
                str[i] = '9';
            }
            return int.Parse(str);
        }
        public int LeetCode_968_MinCameraCover(TreeNode root)
        {
            int res = 0;

            int Traversal(TreeNode node)
            {
                if (node == null) return 2;
                int left = Traversal(node.left);
                int right = Traversal(node.right);
                if (left == 2 && right == 2)
                {
                    return 0;
                }

                if (left == 0 || right == 0)
                {
                    res++;
                    return 1;
                }

                if (left == 1 || right == 1)
                {
                    return 2;
                }

                return -1;
            }

            if (Traversal(root) == 0)
            {
                res++;
            }

            return res;
        }
    }
}
