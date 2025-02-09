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

            int[] number = [1, 2, 6, 3, 4, 5, 8, 7];

            //CompareTypesDelegate<int, int ,bool> Compare = CompareTypes.CompareLessThan;
            //SortingAlgorithm<int>.BubbleSort(number, Compare);

            //Console.WriteLine(string.Join(" ,", number));

            ////string[] names = ["sherouk", "mohy", "mohamed", "eman"];
            ////CompareTypesDelegate<string> Compare = CompareTypes.CompareGreaterThan;
            ////SortingAlgorithm<string>.BubbleSort(names, Compare);
            ////Console.WriteLine(string.Join(" ,", names));

            #endregion

            #region EX03 :

            //List<int> numbers =Enumerable.Range(0, 100).ToList();

            //List<int > result = FindElements(numbers , MethodCondition.IsOdd);
            //Console.WriteLine(string.Join(" ,", result));



            #endregion


            //Part 02:
            #region 2.Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:

            Book book = new Book("100", "Advanced_C#", new string[] { "Ahmed", "Abdelrahman" }, new DateTime(2024, 1, 1), 200m);
            List<Book> bookList = new List<Book>
        {
            new Book("100", "Advanced_C#", new string[] { "Ahmed", "Abdelrahman" }, new DateTime(2024, 1, 1), 200m),
            new Book("200", "Advanced C++", new string[] { "mohamed" }, new DateTime(2025, 1, 1), 100m)
        };

            #endregion

            #region Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

            //LibraryEngine.ProcesBooks(bookList, BookFunctions.GetPrice);

            #endregion

            #region  Use the Proper build in delegate.


            //Func<Book, string> func = BookFunctions.GetPrice;
            //string output = func.Invoke(book);
            //Console.WriteLine(output);
            #endregion

            #region Anonymous Method (GetISBN).
            //BookDelegate bookDelegate = delegate (Book book1)
            //{
            //    return book1.ISBN;
            //};

            #endregion

            #region  Lambda Expression (GetPublicationDate)

            //BookDelegate bookDelegate = book => book.PublicationDate.ToUniversalTime().ToString();
            //string output = bookDelegate.Invoke(book);
            //Console.WriteLine(output);

            //Func<Book, DateTime> func = book => book.PublicationDate;
            //DateTime dateTime = func(book);
            //Console.WriteLine(dateTime.ToString());

            #endregion

            #region We need to Implement the List methods from scratch with all overloads.


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Exist: " + ListMethods<int>.Exist(numbers, x => x == 5));
            Console.WriteLine("Find: " + ListMethods<int>.Find(numbers, x => x > 2));
            Console.WriteLine("FindAll: " + string.Join(", ", ListMethods<int>.FindAll(numbers, x => x > 1)));

            Console.WriteLine("FindIndex: " + ListMethods<int>.FindIndex(numbers, x => x == 3));

            Console.WriteLine("FindLast: " + ListMethods<int>.FindLast(numbers, x => x > 3));
            Console.WriteLine("FindLastIndex: " + ListMethods<int>.FindLastIndex(numbers, x => x > 2)); 
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
