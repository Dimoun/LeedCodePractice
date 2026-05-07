using LeetCode.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode.Tree
{
    public class TreeAlgorithms
    {
        public IList<int> LeetCode_144_PreorderTraversal(TreeNode root)
        {
            //Method1 递归
            //IList<int> res = new List<int>();
            //void Traverse(IList<int> res, TreeNode root)
            //{
            //    if (root == null) return;

            //    res.Add(root.val);
            //    Traverse(res, root.left);
            //    Traverse(res, root.right);

            //} 
            //Traverse(res,root);
            //return res;

            //Method2 迭代
            IList<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                res.Add(node.val);
                if (node.right != null)
                {
                    stack.Push(node.right);
                }
                if (node.left!=null)
                {
                    stack.Push(node.left);
                }
            }
            return res;
        }
        public IList<int> LeetCode_94_InorderTraversal(TreeNode root)
        {
            //Medhod 1 递归
            //void Traverse(IList<int> res, TreeNode node)
            //{
            //    if(node == null) return;
            //    Traverse(res,node.left);
            //    res.Add(node.val);
            //    Traverse(res,node.right);
                
            //}

            //IList<int> res = new List<int>();
            //Traverse(res,root);
            //return res;
            //Mehtod 2 迭代
            IList<int> res = new List<int>();
            if (root == null) return res;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;
            while (cur!=null || stack.Count > 0)
            {
                if (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                else
                {
                    cur = stack.Pop();
                    res.Add(cur.val);
                    cur = cur.right;
                }
            }
            return res;
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            //Method1 递归
            //void Traverse(IList<int> res, TreeNode node)
            //{
            //    if (node == null) return;
            //    Traverse(res,node.left);
            //    Traverse(res,node.right);
            //    res.Add(node.val);
            //}

            //IList<int> res = new List<int>();
            //Traverse(res,root);
            //return res;

            //Method2 迭代
            IList<int> res = new List<int>();
            if (root == null) return res;
            Stack<TreeNode> stack = new Stack<TreeNode>();
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
    }
}
