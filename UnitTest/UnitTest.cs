using LeetCode;
using LeetCode.Classisc;
using LeetCode.LeetCode;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_Claaics100()
        {
            Classics_66 classics = new Classics_66();
            int[] res = classics.PlusOne(new[] { 9,9 });
            
        }
        [TestMethod]
        public void Test_Claaics67()
        {
            Classics_67 classics = new Classics_67();
            classics.AddBinary("1010","1011");
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
    }
}