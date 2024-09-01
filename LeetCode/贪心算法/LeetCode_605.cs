using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode_605
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            //贪心
            //能种花的地方
            //当前位置没有花
            //前面要么没有花, 要么是边界
            //后面要么没有花, 要么是边界
            
            for (int i= 0; i < flowerbed.Length; i++){
                if(flowerbed[i] == 0 &&(i==0||flowerbed[i-1]==0) && (i == flowerbed.Length || flowerbed[i + 1] == 0))
                {
                    n--;
                    flowerbed[i] = 1;
                }
                if (n <= 0)
                {
                    return true;
                }
            }
 
            return false;
        }
    }
}
