using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.Classisc
{
    public class Classics_114
    {
        public void Flatten(TreeNode root)
        {
            List<TreeNode> list = new List<TreeNode>();
            Preorder(root, list);
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                TreeNode cur = list[i];
                cur.left = null;
                cur.right = i == count - 1 ? null : list[i + 1];
            }
        }
        public void Preorder(TreeNode root, List<TreeNode> list)
        {
            if (root == null)
                return;

            list.Add(root);
            Preorder(root.left,list);
            Preorder(root.right,list);
        }
    }
}
