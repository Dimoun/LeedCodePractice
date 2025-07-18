using LeetCode.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.Tree
{
    public class TreeAlgorithms
    {
        public IList<int> LeetCode_144_PreorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            void Traverse(IList<int> res, TreeNode root)
            {
                if (root == null) return;

                res.Add(root.val);
                Traverse(res, root.left);
                Traverse(res, root.right);

            } 
            Traverse(res,root);
            return res;
        }

    }
}
