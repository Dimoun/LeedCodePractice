using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
     public class TreeNode
        {
         public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
             }
      }
 
    public class LeetCode_938
    {
        int sum = 0;
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            //Method 1
            if (root != null)
            {
                if (root.val >= low && root.val <= high)
                {
                    sum += root.val;
                    Console.WriteLine(root.val);
                }
                RangeSumBST(root.left, low, high);
                RangeSumBST(root.right, low, high);
            }

            return sum;


            //Method 2
            if (root == null)
                return 0;

            if(root.val > high)
            {
                return RangeSumBST(root.left, low, high);
            }if(root.val < low)
            {
                return RangeSumBST(root.right, low, high);
            }
            
            return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }
    }
}
