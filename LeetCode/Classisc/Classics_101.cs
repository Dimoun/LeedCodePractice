using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Others;

namespace LeetCode.Classisc
{
    class Classics_101
    {
        public bool IsSymmetric(TreeNode root)
        {
            //Method 1 递归
            //if(root == null)
            //    return true; 


            //return IsEqual(root.left,root.right);

            //Method2 Queue

            if (root == null || (root.left == null && root.right == null))
                return true;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root.left);
            queue.Enqueue(root.right);

            while(queue.Count > 0)
            {
                TreeNode left = queue.Dequeue();
                TreeNode right = queue.Dequeue();
                if (left != null && right != null)
                    continue;
                if (left == null || right == null)
                    return false;
                if(left.val!= right.val)
                {
                    return false;
                }
                queue.Enqueue(left.left);
                queue.Enqueue(right.right);
                queue.Enqueue(left.right);
                queue.Enqueue(right.left);
            }
            return true;
           

        }
        public bool IsEqual(TreeNode left,TreeNode right)
        {
            if (left == null && right == null)
                return true;
            if (left == null || right == null)
                return false;
            if (left.val != right.val)
                return false;
            return IsEqual(left.left,right.right) && IsEqual(left.right,right.left);
        }
    }
}
