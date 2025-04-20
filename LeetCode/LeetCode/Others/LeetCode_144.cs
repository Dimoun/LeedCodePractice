using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    public class LeetCode_144
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            Preorder(root, list);

            return list;
        }

        public void Preorder(TreeNode root, IList<int> list)
        {
            if (root == null)
                return;

            list.Add(root.val);
            Preorder(root.left, list);
            Preorder(root.right, list);
        }
    }
}
