using LeetCode.Classisc;
using LeetCode.BackTrack;
using LeetCode.Greedy;
using LeetCode.LeetCode.DP;
using LeetCode.Others;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_Claaics100()
        {
            Classics_66 classics = new Classics_66();
            int[] res = classics.PlusOne(new[] { 9, 9 });

        }
        [TestMethod]
        public void Test_Classiccs67()
        {
            Classics_67 classics = new Classics_67();
            classics.AddBinary("1010", "1011");
        }

        [TestMethod]
        public void Test_LeetCode1115()
        {
            LeetCode_1115 leetcode = new LeetCode_1115(10);
            Task.Run(() =>
            {
                leetcode.Foo();
            });
            Task.Run(() =>
            {
                leetcode.Bar();
            });
        }
        [TestMethod]
        public void Test_Claaics51()
        {
            Classics_151 classics = new Classics_151();
            classics.ReverseWords("  a good   example ");
        }
        [TestMethod]
        public void Test_Claaics155()
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5
            };
            Classics_155 classics = new Classics_155();

            classics.Push(2);
            classics.Push(0);
            classics.Push(3);
            classics.Push(0);
            int a = classics.GetMin();
            classics.Pop();
            classics.Top();
            classics.GetMin();
        }

        [TestMethod]
        public void Test_Classics_82()
        {
            Classics_82 classics = new Classics_82();

            ListNode node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5, null)))))));
            classics.DeleteDuplicates(node);
        }
        [TestMethod]
        public void Test_Classics_61()
        {
            Classics_61 classics = new Classics_61();

            ListNode node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            classics.RotateRight(node, 2);
        }
        [TestMethod]
        public void Test_Classics_114()
        {
            Classics_114 classics = new Classics_114();

            TreeNode treeNode = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)),
                new TreeNode(5, null, new TreeNode(6)));
            classics.Flatten(treeNode);
        }
        [TestMethod]
        public void Test_Classics_222()
        {
            Classics_222 classics = new Classics_222();

            TreeNode treeNode = new TreeNode(1, new TreeNode(2, new TreeNode(3)));
            classics.CountNodes(treeNode);
        }

        [TestMethod]
        public void Test_LeetCode_257()
        {
            LeetCode_257 leetcode = new LeetCode_257();

            // TreeNode treeNode = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)),
            //     new TreeNode(3, new TreeNode(6), new TreeNode(7)));

            TreeNode treeNode = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)),
                new TreeNode(3, null, null));
            leetcode.BinaryTreePaths(treeNode);
        }
        [TestMethod]
        public void Test_LeetCode_77()
        {
            LeetCode_77 leetcode = new LeetCode_77();

            leetcode.Combine(4, 2);
        }
        [TestMethod]
        public void Test_LeetCode_216()
        {
            LeetCode_216 leetcode = new LeetCode_216();

            leetcode.CombinationSum3(3, 7);
        }
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
        public void Test_LeetCode_131()
        {
            LeetCode_131 leetcode = new LeetCode_131();

            leetcode.Partition("aab");
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
            dp.LeetCode_343_IntegerBreak(10);
        }
    }
}