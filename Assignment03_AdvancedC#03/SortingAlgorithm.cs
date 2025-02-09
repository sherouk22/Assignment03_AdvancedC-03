using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_AdvancedC_03
{
    public delegate Tresult CompareTypesDelegate< in T1,in T2 ,out Tresult>(T1 x , T2 y);
    public class SortingAlgorithm<T>
    {


        public static void Swap<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }

        public static void BubbleSort<T>(T[] arr, CompareTypesDelegate<T,T,bool> compare)
        {
            if (arr is not null && arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (compare.Invoke(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
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


        public static bool CompareGreaterThan(string  X, string Y)
        {
            return X?.Length > Y?.Length;
        }

        public static bool CompareLessThan(string X, string Y)
        {
            return X?.Length < Y?.Length;
        }

    }

}
