using LeetCode.Classisc;
using LeetCode.BackTrack;
using LeetCode.LeetCode.ArrayAlgorithm;
using LeetCode.LeetCode.DP;
using LeetCode.Others;
using LeetCode.LeetCode.BinaryTree;
using LeetCode.LeetCode.DoublePointer;
using LeetCode.LeetCode.Greedy;
using LeetCode.LeetCode.Hash;
using LeetCode.LeetCode.HashTable;
using LeetCode.LeetCode.LinkedTable;
using LeetCode.LeetCode.StackQueue;
using LeetCode.LeetCode.StringAlgorithms;
using LeetCode.LeetCode.Tree;
using ListNode = LeetCode.LeetCode.LinkedTable.ListNode;
using static LeetCode.LeetCode.LinkedTable.LinkedTable;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_LeetCode_BackTrack()
        {
            //LeetCode_39 leetcode = new LeetCode_39();

            //leetcode.CombinationSum(new int[]{2,3,6,7},7);

            //LeetCode_40 leetcode = new LeetCode_40();
            //LeetCode_93 leetcode = new LeetCode_93();
            //LeetCode_78 leetcode = new LeetCode_78();
            //LeetCode_90 leetcode = new LeetCode_90();
            //LeetCode_491 leetcode = new LeetCode_491();
            //LeetCode_46 leetcode = new LeetCode_46();
            //LeetCode_47 leetcode = new LeetCode_47();
            LeetCode_51 leetcode = new LeetCode_51();

            leetcode.SolveNQueens(4);
        }
        [TestMethod]
        public void Test_LeetCode_Greedy()
        {
            //LeetCode_376 leetcode = new LeetCode_376();

            //leetcode.WiggleMaxLength(new int[]{ 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 });

            //LeetCode_53 leetcode = new LeetCode_53();

            //leetcode.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            Greedy greedy = new Greedy();
            //greedy.LeetCode_122_MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            //greedy.LeetCode_45_Jump(new int[]{ 2, 3, 1, 1, 4 });
            //greedy.LeetCode_1005_LargestSumAfterKNegations(new int[] { 4, 2, 3 }, 1);
            //greedy.LeetCode_134_CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[]{ 3, 4, 5, 1, 2 });
            //greedy.LeetCode_860_LemonadeChange(new int[] { 5, 5, 5, 5, 20, 20, 5, 5, 20, 5 });
            //greedy.LeetCode_860_LemonadeChange(new int[] { 5, 5, 5, 10, 20 });
            //greedy.LeetCode_406_ReconstructQueue(new int[][]
            //{
            //    new int[]{ 7, 0 },
            //    new int[]{ 4, 4 },
            //    new int[]{ 7, 1 },
            //    new int[]{ 5, 0 },
            //    new int[]{ 6, 1 },
            //    new int[]{ 5, 2 },

            //});
            //greedy.LeetCode_452_FindMinArrowShots(new int[][]
            //{
            //    new int[]{ -2147483646, -2147483645 },
            //    new int[]{ 2147483646, 2147483647 },
            //    //new int[]{ 5, 6 },
            //    //new int[]{ 7, 8 },

            //});
            //greedy.LeetCode_435_EraseOverlapIntervals(new int[][]
            //{
            //    new int[]{ 0, 2 },
            //    new int[]{ 1,3 },
            //    new int[]{ 2, 4 },
            //    new int[]{ 3, 5 },
            //    new int[]{ 4, 6 },

            //});
            //greedy.LeetCode_763_PartitionLabels("ababcbacadefegdehijhklij");
            //greedy.LeetCode_738_MonotoneIncreasingDigits(332);
            greedy.LeetCode_968_MinCameraCover(new TreeNode(0,
                new TreeNode(0, 
                    new TreeNode(0, 
                        new TreeNode(0, null, new 
                            TreeNode(0, null, null)), null), null),
                null));

            //greedy.LeetCode_56_Merge(new int[][]
            //{
            //    new int[] { 1, 3 },
            //    new int[] { 2, 6 },
            //    new int[] { 8, 10 },
            //    new int[]{15,18}
            //});
       }

        [TestMethod]
        public void Test_LeetCode_BinaryTree()
        {
            BinaryTree tree = new BinaryTree();
            TreeNode node = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null), null));
            tree.LeetCode_107_LevelOrderBottom(node);
        }

        [TestMethod]
        public void Test_LeetCode_DP()
        {
            DP dp = new DP();
            //dp.LeetCode_70_ClimbStairs(3);
            //dp.LeetCode_63_UniquePathsWithObstacles(new int[][]
            //{
            //    new int[]{0,0},
            //    //new int[] { 0, 0, 0 },
            //    //new int[] { 0, 1, 0 },
            //    //new int[] { 0, 0, 0 },
            //});
            //dp.LeetCode_343_IntegerBreak(10);
            dp.LeetCode_96_NumTrees(3);
        }

        [TestMethod]
        public void Test_LeetCode_Array()
        {
            ArrayAlgorithm arrayAlgorithm = new ArrayAlgorithm();
            //int[] array = new int[]{-1,0,3,5,9,12};
            //arrayAlgorithm.LeetCode_704_Search(array, 9);
            //arrayAlgorithm.LeetCode_27_RemoveElement(new[] { 3, 2, 2, 3 }, 3);
            //arrayAlgorithm.LeetCode_209_MinSubArrayLen(7, new[] { 2, 3, 1, 2, 4, 3 });
            arrayAlgorithm.LeetCode_59_GenerateMatrix(4);
        }

        [TestMethod]
        public void Test_LeetCode_LinkedTable()
        {
            LinkedTable linkedTable = new LinkedTable();
            //ListNode node = new ListNode(7, new ListNode(7, new ListNode(1, null)));
            //linkedTable.LeetCode_203_RemoveElements(node,7);
            //MyLinkedList myLinkedList = new MyLinkedList();
            //myLinkedList.AddAtHead(1);
            //myLinkedList.AddAtTail(3);
            //myLinkedList.AddAtIndex(1, 2);    // 链表变为 1->2->3
            //myLinkedList.Get(1);              // 返回 2
            //myLinkedList.DeleteAtIndex(1);    // 现在，链表变为 1->3
            //myLinkedList.Get(1);              // 返回 3

            ListNode node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4,null))));
            //linkedTable.LeetCode_24_SwapPairs(node);
            linkedTable.LeetCode_19_RemoveNthFromEnd(node,2);
        }

        [TestMethod]
        public void Test_LeetCode_HashTable()
        {
            Hash hashTable = new Hash();
            //hashTable.LeetCode_242_IsAnagram("anagram", "nagaram");
            //hashTable.LeetCode_349_Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            //hashTable.LeetCode_15_ThreeSum(new int[] { -1, 0, 1, -1,1,0});
            var a = hashTable.LeetCode_18_FourSum(new[] { 1000000000, 1000000000, 1000000000, 1000000000 },-294967296);
        }

        [TestMethod]
        public void Test_LeetCode_String()
        {
            StringAlgorithms stringAlgorithms = new StringAlgorithms();
            ////stringAlgorithms.LeetCode_541_ReverseStr("a",2);
            //stringAlgorithms.LeetCode_151_ReverseWords(" hello world  ");
            stringAlgorithms.LeetCode_28_StrStr("a", "a");
        }

        [TestMethod]
        public void Test_LeetCode_DoublePoint()
        {
            DoublePointer dp = new DoublePointer();
            dp.LeetCode_27_RemoveElement(new int[]{3,2,2,3},3);
        }

        [TestMethod]
        public void Test_LeetCode_StackQueue()
        {
            StackQueue sq = new StackQueue();
            //sq.LeetCode_20_IsValid("()[]{}");
            //sq.LeetCode_1047_RemoveDuplicates("abbaca");
            //sq.LeetCode_347_TopKFrequent(new int[] { 3,0,0,1 }, 1);
            //sq.LeetCode_150_EvalRPN(new string[] { "4", "13", "5", "/", "+" });
            sq.LeetCode_239_MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
        }

        [TestMethod]
        public void Test_LeetCode_Tree()
        {
            TreeAlgorithms treeAlgorithms = new TreeAlgorithms();
            treeAlgorithms.LeetCode_144_PreorderTraversal(new TreeNode(1, null,
                new TreeNode(2, new TreeNode(3, null, null), null)));
        }
    }
}