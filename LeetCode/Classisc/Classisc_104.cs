using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Others;

namespace LeetCode.Classisc
{
    public class Classisc_104
    {
        public int MaxDepth(TreeNode root)
        {
            //深度优先
            if (root == null)
                return 0;
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return Math.Max(left,right)+1;

            //广度优先
            if (root == null)
                return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int num = 0;
            while(queue.Count > 0)
            {
                int size = queue.Count;
                while (size > 0)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    size--;
                }
                num++;
            }
            return num;
        }
    }
}
