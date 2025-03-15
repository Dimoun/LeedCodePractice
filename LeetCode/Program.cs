using LeetCode.Classisc;
using LeetCode.InterviewQ;
using LeetCode.LeetCode;
using LeetCode.哈希表;
using System;
using LeetCode.Greedy;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            //_leetCode_2591();
            //_leetCode_605();
            //_leetCode_697();
            //_leetCode_414();
            //_leetCode_424();
            //_leetCode_938();
            //_leetCode1313();
            //_leetCode2154();
            //_Offer05();
            //_Classics383();
            //_Classics88();
            //_Classics27();
            //_Classics35();
            //_Classics205();
            //_Classics228();
            //_Classics20();
            //_Classics125();
            //_Classics392();
            //_Classics9();
            //_Classics290();
            //_LeetCode1060();
            //_LeetCode754();
            //_LeetCode2535();
            //_Classics80();
            //_LeetCode1796();
            //_Interview_16_15();
            //_LeetCode_283();
            //_LeetCode_11();
            //_LeetCode_2();
            //_Classics45();
            //_LeetCode225();
            //_Classics380();
            //_Classics13();
            //_Classics28();
            //_Classics11();
            _Classics3();

        }
        public static void _leetCode_2591()
        {
            LeetCode_2591 leetCode_2591 = new LeetCode_2591();
            int n = leetCode_2591.DistMoney(19, 2);
            System.Console.WriteLine(n);
        }

        public static void _leetCode_605()
        {
            LeetCode_605 leetCode_605 = new LeetCode_605();
            int[] fl = new int[] { 1, 0, 0, 0, 1 };
            bool res = leetCode_605.CanPlaceFlowers(fl, 1);
            System.Console.WriteLine(res);
        }

        public static void _leetCode_697()
        {
            LeetCode_697 leetCode_697 = new LeetCode_697();
            int[] arr = new int[] { 1, 2, 2, 3, 1 };
            int n = leetCode_697.FindShortestSubArray(arr);
            System.Console.WriteLine(n);
        }
        public static void _leetCode_414()
        {
            LeetCode_414 leetCode_414 = new LeetCode_414();
            int[] arr = new int[] { -3, -2, -1, 0 };
            int n = leetCode_414.ThirdMax(arr);
            System.Console.WriteLine(n);
        }

        public static void _leetCode_424()
        {
            LeetCode_424 leetCode_424 = new LeetCode_424();
            string s = "AABABBA";
            int k = 2;
            int n = leetCode_424.CharacterReplacement(s, 1);
            System.Console.WriteLine(n);
        }

        public static void _leetCode_938()
        {
            LeetCode_938 leetCode_938 = new LeetCode_938();

            TreeNode treeNode = new TreeNode(10, new TreeNode(5, new TreeNode(3, null, null), new TreeNode(7, null, null)), new TreeNode(15, null, new TreeNode(18, null, null)));
            leetCode_938.RangeSumBST(treeNode, 7, 16);
        }

        public static void _leetCode1313()
        {
            LeetCode_1313 leetCode_1313 = new LeetCode_1313();

            int[] arr = new int[] { 1, 2, 3, 4 };
            leetCode_1313.DecompressRLElist(arr);
        }
        public static void _leetCode2154()
        {
            LeetCode_2154 leetCode_2154 = new LeetCode_2154();

            int[] arr = new int[] { 5, 3, 6, 1, 12 };
            leetCode_2154.FindFinalValue(arr, 3);
        }

        public static void _Offer05()
        {
            Offer_05 offer_05 = new Offer_05();
            string str = "We are happy.";
            offer_05.ReplaceSpace(str);
        }

        public static void _Classics383()
        {
            Classics_383 classics383 = new Classics_383();

            string ran = "a";
            string mag = "b";
            classics383.CanConstruct(ran, mag);
        }
        public static void _Classics88()
        {
            Classisc_88 classics88 = new Classisc_88();

            int[] arr1 = new int[] { 0 };
            int[] arr2 = new int[] { 1 };

            classics88.Merge(arr1, 0, arr2, 1);
        }
        public static void _Classics27()
        {
            Classics_27 classics27 = new Classics_27();

            int[] arr = new int[] { 3, 2, 2, 3 };

            int num = classics27.RemoveElement(arr, 3);
        }
        public static void _Classics35()
        {
            Classics_35 classics35 = new Classics_35();

            int[] arr = new int[] { 1, 3, 5, 6 };

            int res = classics35.SearchInsert(arr, 2);
        }

        public static void _Classics205()
        {
            Classics_205 classics205 = new Classics_205();

            string s = "egg";
            string t = "add";

            bool res = classics205.IsIsomorphic(s, t);
        }
        public static void _Classics228()
        {
            Classics_228 classics228 = new Classics_228();
            int[] nums = { 0, 2, 3, 4, 6, 8, 9 };

            var res = classics228.SummaryRanges(nums);
        }
        public static void _Classics20()
        {
            Classics_20 classics20 = new Classics_20();
            string s = "){";
            var res = classics20.IsValid(s);
        }
        public static void _Classics125()
        {
            Classics_125 classics125 = new Classics_125();
            string s = "race a car";
            var res = classics125.IsPalindrome(s);
        }
        public static void _Classics392()
        {
            Classics_392 classics392 = new Classics_392();
            string s = "axc", t = "axc";
            var res = classics392.IsSubsequence(s, t);
        }
        public static void _Classics9()
        {
            Classics_9 classics9 = new Classics_9();
            int x = 10;
            var res = classics9.IsPalindrome(x);
        }
        public static void _Classics290()
        {
            Classics_290 classics290 = new Classics_290();
            string pattern = "aaaa";
            string s = "dog dog dog dog";
            var res = classics290.WordPattern(pattern, s);
        }

        public static void _Classics80()
        {
            Classics_80 classics80 = new Classics_80();

            int[] nums = { 1, 2, 2 };
            var res = classics80.RemoveDuplicates(nums);
        }

        public static void _LeetCode1060()
        {
            LeetCode_1160 _leetCode1060 = new LeetCode_1160();

            string[] words = { "cat", "bt", "hat", "tree" };
            string chars = "atach";

            var res = _leetCode1060.CountCharacters(words, chars);

        }
        public static void _LeetCode754()
        {
            LeetCode_754 _leetCode754 = new LeetCode_754();
            var res = _leetCode754.ReachNumber(5);
        }
        public static void _LeetCode2535()
        {
            LeetCode_2535 _leetCode2535 = new LeetCode_2535();
            int[] num = { 1, 15, 6, 3 };
            var res = _leetCode2535.DifferenceOfSum(num);
        }
        public static void _LeetCode1796()
        {
            LeetCode_1796 _leetCode1796 = new LeetCode_1796();
            string s = "abc1111";
            var res = _leetCode1796.SecondHighest(s);
        }
        public static void _Interview_16_15()
        {
            Interview_16_15 _interview_16_15 = new Interview_16_15();
            string sol = "GRRR";
            string guess = "RBYB";
            var res = _interview_16_15.MasterMind(sol, guess);
        }
        public static void _LeetCode_283()
        {
            LeetCode_283 leetCode = new LeetCode_283();
            int[] nums = { 0, 1, 0, 3, 12 };
            leetCode.MoveZeroes(nums);
        }
        public static void _LeetCode_11()
        {
            LeetCode_11 leetCode = new LeetCode_11();
            //int[] nums = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] nums = { 1, 1 };
            leetCode.MaxArea(nums);
        }
        public static void _LeetCode_2()
        {
            LeetCode_2 leetCode = new LeetCode_2();
            LeetCode.ListNode node1 = new LeetCode.ListNode(9,
                new LeetCode.ListNode(9,
                new LeetCode.ListNode(9,
                new LeetCode.ListNode(9,
                new LeetCode.ListNode(9,
                new LeetCode.ListNode(9,
                new LeetCode.ListNode(9, null)))))));
            LeetCode.ListNode node2 = new LeetCode.ListNode(9,
                new LeetCode.ListNode(9,
                new LeetCode.ListNode(9,
                new LeetCode.ListNode(9, null))));

            leetCode.AddTwoNumbers(node1, node2);
        }
        public static void _Classics45()
        {
            Classics_45 classics = new Classics_45();
            int[] nums = { 2, 1 };
            classics.Jump(nums);
        }
        public static void _LeetCode225()
        {
            LeetCode_225.MyStack myStack = new LeetCode_225.MyStack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
        }
        public static void _Classics71()
        {
            Classics_71 classics = new Classics_71();
            string str = "/a//b////c/d//././/..";
            string res = classics.SimplifyPath(str);
        }
        public static void _Classics380()
        {
            Classics_380 randomizedSet = new Classics_380();
            randomizedSet.Insert(1); // 向集合中插入 1 。返回 true 表示 1 被成功地插入。
            randomizedSet.Insert(2); // 向集合中插入 2 。返回 true 。集合现在包含 [1,2] 。
            randomizedSet.Remove(1); // 返回 false ，表示集合中不存在 2 。
            randomizedSet.GetRandom(); // getRandom 应随机返回 1 或 2 。
            randomizedSet.Remove(1); // 从集合中移除 1 ，返回 true 。集合现在包含 [2] 。
            randomizedSet.Insert(2); // 2 已在集合中，所以返回 false 。
            randomizedSet.GetRandom(); // 由于 2 是集合中唯一的数字，getRandom 总是返回 2 
        }

        public static void _Classics13()
        {
            Classics_13 classics = new Classics_13();
            classics.RomanToInt("III");
            classics.RomanToInt("IV");
            classics.RomanToInt("IX");
            classics.RomanToInt("LVIII");
            classics.RomanToInt("MCMXCIV");

        }
        public static void _Classics28()
        {
            Classics_28 classics = new Classics_28();
            int a = classics.StrStr("sadbutsad", "sad");
        }
        public static void _Classics11()
        {
            Classics_11 classics = new Classics_11();
            int a = classics.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        }
        public static void _Classics3()
        {
            Classics_3 classics = new Classics_3();
            int a = classics.LengthOfLongestSubstring("pwwkew");
        }
    }
}
