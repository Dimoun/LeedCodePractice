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
    }
}