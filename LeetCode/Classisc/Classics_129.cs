using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_129
    {
        public int SumNumbers(TreeNode root)
        {
            int sum = 0;
            return DFS(root,sum);
        }
        public int DFS(TreeNode root, int preSum)
        {
            if(root == null) return 0;

            int sum = root.val + preSum * 10 ;

            if (root.left == null && root.right == null)
            {
                return sum;
            }
            return DFS(root.left, sum) + DFS(root.right, sum);
        }

        public int BFS(TreeNode root)
        {
            Queue<TreeNode> nodeList = new Queue<TreeNode>();
            Queue<int> valueList = new Queue<int>();

            nodeList.Enqueue(root);
            valueList.Enqueue(root.val);
            int sum = 0;

            while (nodeList.Count > 0)
            {
                TreeNode node = nodeList.Dequeue();
                int num = valueList.Dequeue();
                if (node.left == null && node.right == null)
                {
                    sum += num;
                }else
                {
                    if (node.left != null)
                    {
                        nodeList.Enqueue(node.left);
                        valueList.Enqueue(num*10 + node.left.val);
                    }

                    if (node.right != null)
                    {
                        nodeList.Enqueue(node.right);
                        valueList.Enqueue(num*10 + node.right.val);
                    }
                }
            }

            return sum;
        }
    }
}
