using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_AdvancedC_03
{
    public delegate bool CompareTypesDelegate(int x , int y);
    public class SortingAlgorithm
    {


        public static void Swap(ref int X, ref int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }

        public static void BubbleSort(int[] arr , CompareTypesDelegate Compare)
        {
            if(arr is  null || arr.Length == 0) 
                return;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                    if (Compare.Invoke(arr[j], arr[j + 1]))
                        Swap(ref arr[j], ref arr[i + 1]);

            }


        }




    }

   public class CompareTypes 
    {
        public static bool CompareGreaterThan( int X,  int Y)
        {
            return X > Y;
        }

        public static bool CompareLessThan( int X,  int Y)
        {
            return X < Y;
        }

    }

}
