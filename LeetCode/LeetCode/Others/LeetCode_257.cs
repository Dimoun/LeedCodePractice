using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Others
{
    public class LeetCode_257
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> res = [];
            //IList<int> list = [];
            ////DFS(list, res, root);
            //Traversal(root,list, res);
            //return res;

            DFS(root, "", res);
            return res;

        }
        /*
         * 方法存在问题 ，测试用例通过207/208
         */
        public void DFS(IList<int> list, IList<string> res, TreeNode root)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null)
            {
                int count = list.Count;
                StringBuilder sb = new StringBuilder();
                foreach (int item in list)
                {
                    sb.Append(item).Append("->");
                }
                sb.Append(root.val);
                res.Add(sb.ToString());
                return;
            }
            list.Add(root.val);
            DFS(list, res, root.left);
            DFS(list, res, root.right);
            list.Remove(root.val);
        }
        public void Traversal(TreeNode node, IList<int> path, IList<string> res)
        {
            if (node == null)
                return;
            path.Add(node.val);
            if (node.left == null && node.right == null)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < path.Count - 1; i++)
                {
                    sb.Append(path[i]).Append("->");
                }

                sb.Append(node.val);
                res.Add(sb.ToString());
                return;
            }
            if (node.left != null)
            {
                Traversal(node.left, path, res);
                path.RemoveAt(path.Count - 1);
            }
            if (node.right != null)
            {
                Traversal(node.right, path, res);
                path.RemoveAt(path.Count - 1);
            }
        }
        private void DFS(TreeNode root, string s, IList<string> res)
        {
            if (root != null)
            {
                StringBuilder sb = new StringBuilder(s);
                sb.Append(root.val);
                if (root.right == null && root.left == null)
                {
                    res.Add(sb.ToString());
                }
                else
                {
                    sb.Append("->");
                    DFS(root.left, sb.ToString(), res);
                    DFS(root.right, sb.ToString(), res);
                }
            }
        }
    }

}
