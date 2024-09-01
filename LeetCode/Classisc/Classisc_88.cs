using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Classisc_88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            ////Method 1
            //for (int i = 0; i < n; i++)
            //{
            //    nums1[m + i] = nums2[i];
            //}
            //Array.Sort(nums1);

            //Method 2

            int indexM = m - 1;
            int indexN = n - 1;
            int index = m + n - 1;
            while(indexM >= 0 && indexN >= 0)
            {
                if(nums1[indexM] >= nums2[indexN])
                {
                    nums1[index] = nums1[indexM];
                    index--;
                    indexM--;
                }
                else
                {
                    nums1[index] = nums2[indexN];
                    index--;
                    indexN--;
                }
            }

            if (indexM >= 0)
            {
               for(int i=0; i<=indexM; i++)
                {
                    nums1[i] = nums1[i];
                }
            }
            if(indexN >= 0)
            {
                for (int i = 0; i <= indexN; i++)
                {
                    nums1[i] = nums2[i];
                }
            }
       
        }
    }
}

