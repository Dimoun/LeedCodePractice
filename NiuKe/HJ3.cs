using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiuKe
{
    public class HJ3
    {
        public int[] SortRandom(int[] arr, int n) {

            HashSet<int> set = new HashSet<int>();

            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {

                if (!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);
                }
            }
            int[] array = set.ToArray();
            int length = array.Length;
            for(int i = 0; i < length; i++)
            {
                for (int j = i+1; j < length; j++) { 
                    
                    int temp = array[i];
                    if (temp > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            for(int i = 0; i < length; i++)
            {
                System.Console.Write(array[i]);
            }

            return array;
        }
    }
}
