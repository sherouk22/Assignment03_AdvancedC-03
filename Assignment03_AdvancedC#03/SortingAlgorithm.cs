using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_AdvancedC_03
{
    public class SortingAlgorithm
    {


        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void BubbleSort(int[] arr)
        {
            if(arr is  null || arr.Length == 0) 
                return;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                    if (arr[j] > arr[i + 1])
                        Swap(ref arr[j], ref arr[i + 1]);

            }


        }

        


    }
}
