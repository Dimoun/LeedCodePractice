using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.ArrayAlgorithm
{
    public class ArrayAlgorithm
    {
        public int LeetCode_704_Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        public int LeetCode_27_RemoveElement(int[] nums, int val)
        {
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (val != nums[fast])
                {
                    nums[slow++] = nums[fast];
                }
            }
            return slow;
        }
        public int[] LeetCode_977_SortedSquares(int[] nums)
        {
            //Method1  暴力解法
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);
            return nums;

            //Method2 双指针
            int len = nums.Length;
            int[] res = new int[len];

            int k = len - 1;
            for (int i = 0,j=len-1; i <=j;)
            {
                if (nums[i] * nums[i] < nums[j] * nums[j])
                {
                    res[k--] = nums[j]*nums[j];
                    j--;
                }
                else
                {
                    res[k--] = nums[i] * nums[i];
                    i++;
                }
            }

            return res;
        }
        public int LeetCode_209_MinSubArrayLen(int target, int[] nums)
        {
            //Method1 暴力解法
            int res = int.MaxValue;
            int sum = 0;
            int len = nums.Length;
            //for (int i = 0; i < len; i++)
            //{
            //    sum = 0;
            //    for (int j = i; j < len; j++)
            //    {
            //        sum += nums[j];
            //        if (sum >= target)
            //        {
            //            res = Math.Min(res, j - i + 1);
            //            break; 
            //        } 
            //    }
            //}

            //return res == int.MaxValue ? 0 : res;

            //Method2 滑动窗口
            int index = 0;
            for (int i = 0; i < len; i++)
            {
                sum += nums[i];
                while (sum >= target)
                {
                    res = Math.Min(res, i - index + 1);
                    sum -= nums[index];
                    index++;
                }
            }

            return res == int.MaxValue ? 0 : res;

        }
        public int[][] LeetCode_59_GenerateMatrix(int n)
        {
            int[][] nums = new int[n][];
            for (int i = 0; i < n; i++)
            {
                nums[i] = new int[n];
            }
            int startX = 0,startY = 0;
            int offset = 1;
            int count = 1;
            int laps = n / 2;
            while (laps>0)
            {
                for (int i = startY; i < n - offset; i++)
                {
                    nums[startX][i] = count++;
                }

                for (int i = startX; i < n-offset; i++)
                {
                    nums[i][n-offset] = count++;
                }

                for (int i = n-offset; i > startX; i--)
                {
                    nums[n-offset][i] = count++;
                }

                for (int i = n-offset; i > startY; i--)
                {
                    nums[i][startY] = count++;
                }

                laps--;
                offset++;
                startX++;
                startY++;
            }

            if (n % 2 == 1)
            {
                nums[n / 2][n / 2] = n * n;
            }

            return nums;
        }
    }
}
