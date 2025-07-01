using LeetCode.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.BinaryTree
{
    public class BinaryTree
    {
        public IList<int> LeetCode_144_PreorderTraversal(TreeNode root)
        {
            //Method 1 递归
            IList<int> res = new List<int>();

            //void BackTrack(TreeNode node, IList<int> list)
            //{
            //    if (node == null)
            //        return;
            //    list.Add(node.val);
            //    BackTrack(node.left, list);
            //    BackTrack(node.right, list);
            //}

            //BackTrack(root, res);
            //return res;

            //Method 2 迭代法
            //前序遍历
            //Stack<TreeNode> stack = new Stack<TreeNode>();
            //if (root == null)
            //    return res;
            //stack.Push(root);
            //while (stack.Count > 0)
            //{
            //    TreeNode node = stack.Pop();
            //    res.Add(node.val);
            //    if (node.right != null)
            //    {
            //        stack.Push(node.right);
            //    }

            //    if (node.left != null)
            //    {
            //        stack.Push(node.left);
            //    }
            //}

            ////中序遍历
            //Stack<TreeNode> stack = new Stack<TreeNode>();
            //if (root == null)
            //    return res;
            //TreeNode cur = root;
            //while (cur != null || stack.Count > 0)
            //{
            //    if (cur != null)
            //    {
            //        stack.Push(cur);
            //        cur = cur.left;
            //    }
            //    else
            //    {
            //        cur = stack.Pop();
            //        res.Add(cur.val);
            //        cur = cur.right;
            //    }
            //}

            //后续遍历
            Stack<TreeNode> stack = new Stack<TreeNode>();
            if (root == null)
                return res;
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                res.Add(node.val);
                if (node.left != null)
                {
                    stack.Push(node.left);
                }

                if (node.right != null)
                {
                    stack.Push(node.right);
                }
            }
            return (IList<int>)res.Reverse().ToList();
        }
        public IList<IList<int>> LeetCode_102_LevelOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
                return res;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                IList<int> list = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode cur = queue.Dequeue();
                    list.Add(cur.val);
                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                }

                res.Add(list);
            }

            return res;
        }
        public IList<IList<int>> LeetCode_107_LevelOrderBottom(TreeNode root)
        {
            LinkedList<IList<int>> res = new LinkedList<IList<int>>();
            if (root == null)
                return new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                IList<int> list = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode cur = queue.Dequeue();
                    list.Add(cur.val);
                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                }

                res.AddFirst(list);
            }

            return res.ToList();
        }
    }
}
