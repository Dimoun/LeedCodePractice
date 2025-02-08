using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }
            int count = targetSum - root.val;
            if (count == 0 && root.left == null && root.right == null)
            {
                return true;
            }

            return HasPathSum(root.left, count) || HasPathSum(root.right, count);
        }
    }
}
