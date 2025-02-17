using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_637
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            //Method 1
            IList<double> list = new List<double>();
            BFS(root, list);


            //Method 2
            List<int> countList = [] ;
            List<double> sum = [];
            int depth = 0;
            DFS(root, depth, countList,sum);
            int len = countList.Count;
            for (int i = 0; i < len; i++)
            {
                list.Add(sum[i] / countList[i]);
            }

            return list;
        }

        public void BFS(TreeNode root,IList<double> list)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                double sum = 0;
                for (int i = 0; i < count; i++)
                {
                    TreeNode curNode = queue.Dequeue();
                    sum += curNode.val;
                    if (curNode.left != null)
                    {
                        queue.Enqueue(curNode.left);
                    }

                    if (curNode.right != null)
                    {
                        queue.Enqueue(curNode.right);
                    }
                }

                list.Add(sum / count);
            }
        }

        public void DFS(TreeNode root,int level,List<int> list,List<double> sum)
        {
            if (root == null)
                return;

            if (level < sum.Count)
            {
                sum[level] += root.val;
                list[level]++;
            }
            else
            {
                sum.Add(root.val);
                list.Add(1);
            }
            DFS(root.left,level+1,list,sum);
            DFS(root.right,level+1,list,sum);
        }
    }
}
