using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {   
            //Method 1: 深度优先

            if(p==null && q==null)
            {
                return true;
            }
            if(p==null || q == null)
            {
                return false;
            }
            if(p!=null&&q!=null&&p.val == q.val)
            {
                bool left = IsSameTree(p.left, q.left);
                bool right = IsSameTree(p.right, q.right);

                return left && right;
            }

            return false;

            //Method 2: 广度优先
            if(p == null && q == null)
            {
                return true;
            }
            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            queue1.Enqueue(p);
            queue2.Enqueue(q);
            while (queue1.Count>0&&queue2.Count>0)
            {
                TreeNode node1 = queue1.Peek();
                TreeNode node2 = queue2.Peek();
                if (node1.val != node2.val)
                {
                    return false;
                }

                if (node1.left != null && node2.left!=null)
                {
                    queue1.Enqueue(node1.left);
                    queue2.Enqueue(node2.left);
                }
                else
                {
                    if((node1.left!=null && node2.left == null)||(node1.left==null&& node2.left!=null))
                    {
                        return false;
                    }           
                }
                if(node1.right != null&& node2.right!=null)
                {
                    queue1.Enqueue(node1.right);
                    queue2.Enqueue(node2.right);
                }
                else
                {
                    if ((node1.right != null && node2.right == null) || (node1.right == null && node2.right != null))
                    {
                        return false;
                    }

                }
                queue1.Dequeue();
                queue2.Dequeue();
            }
            return true;
        }
    }
}
