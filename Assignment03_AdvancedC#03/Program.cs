using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment03_AdvancedC_03
{//Assignment03_AdvancedC#03

    public delegate int StringMethodsDelegate(string s);

    public delegate bool ConditionDelegate (int n);

   


    internal class Program
    {

        #region Get Number 

        public static List<int> FindElements(List<int> numbers , ConditionDelegate condition )
        {
            List<int> result = new List<int>();
            if (numbers is not null && numbers.Count > 0)
            {
                foreach (int number in numbers)
                    if (condition.Invoke(number))
                        result.Add(number);

            }
            return result;

        }


        #endregion

        static void Main(string[] args)
        {
            //Part 01:
            //Try Every Point Covered in the Lecture.
            #region EX01 :

            //StringMethodsDelegate stringMethodsDelegate;

            //stringMethodsDelegate = StringMethods.GetCountOfUpperCaseChars;
            //stringMethodsDelegate += StringMethods.GetCountOfLowerCaseChars;
            //// stringMethodsDelegate -= StringMethods.GetCountOfLowerCaseChars;

            //Delegate[] x = stringMethodsDelegate.GetInvocationList();
            //foreach (Delegate x2 in x)
            //{
            //    Console.WriteLine(x2.Method);

            //}


            ////int result = stringMethodsDelegate.Invoke("SDFRTdfrtff");
            ////Console.WriteLine(result); 

            #endregion

            #region EX02 :

            //int[] number = [ 1, 2, 6, 3, 4, 5, 8, 7];


            //SortingAlgorithm.BubbleSort(number , CompareTypes.CompareLessThan);

            //Console.WriteLine(string.Join(" ,", number));

            #endregion

            #region EX03 :

            //List<int> numbers =Enumerable.Range(0, 100).ToList();

            //List<int > result = FindElements(numbers , MethodCondition.IsOdd);
            //Console.WriteLine(string.Join(" ,", result));



            #endregion






        }
    }

    #region EX01
    class StringMethods
    {

        public static int GetCountOfUpperCaseChars(string word)
        {
            Console.WriteLine("GetCountOfUpperCaseChars");
            int count = 0;
            if (word != null)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                        count++;

                }

            }
            return count;
        }

        public static int GetCountOfLowerCaseChars(string word)
        {
            Console.WriteLine("GetCountOfLowerCaseChars");
            int count = 0;
            if (word != null)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                        count++;

                }

            }
            return count;
        }



    }

    #endregion

    #region EX03 
    class MethodCondition
    {
        public static bool IsOdd(int X)
        {
            return X % 2 == 1;
        }

        public static bool IsEven(int X)
        {
            return X % 2 == 0;
        }

        public static bool IsBySeven(int X)
        {
            return X % 7 == 0;
        }


    }

    #endregion



}
