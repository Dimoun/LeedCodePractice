using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    public class LeetCode_176
    {
        public bool IsBalanced(TreeNode root)
        {

            bool left = IsBalanced(root.left);

            bool right = IsBalanced(root.right);

            return false;
        }
    }
}
