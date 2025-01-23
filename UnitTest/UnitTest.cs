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
    }
}