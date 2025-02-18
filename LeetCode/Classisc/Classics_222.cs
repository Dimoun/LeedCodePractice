using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_222
    {
        public int CountNodes(TreeNode root)
        {
            if(root == null) return 0;
            //return  CountNodes(root.left) + CountNodes(root.right)+1; 
            return BFS(root);
        }

        public int BFS(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int num = 0;
            while (queue.Count>0)
            {
                TreeNode currNode =  queue.Dequeue();
                num++;

                if (currNode.left != null)
                {
                    queue.Enqueue(currNode.left);
                }

                if (currNode.right != null)
                {
                    queue.Enqueue(currNode.right);
                }
            }

            return num;
        }
    }
}
