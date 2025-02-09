using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_AdvancedC_03
{
    public class ListMethods<T>
    {
        public static bool Exist<T>(List<T> list, Predicate<T> match)
        {
            foreach (T item in list)
            {
                if (match(item))
                    return true;
            }
            return false;
        }


        public static T Find<T>(List<T> list, Predicate<T> match)
        {
            foreach (T item in list)
            {
                if (match(item))
                    return item;
            }
            return default(T);
        }

        public static List<T> FindAll<T>(List<T> list, Predicate<T> match)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (match(item))
                    result.Add(item);
            }
            return result;
        }


        public static int FindIndex<T>(List<T> list, Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                    return i;
            }
            return -1;
        }


        public static T FindLast<T>(List<T> list, Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                    return list[i];
            }
            return default(T);
        }


        public static int FindLastIndex<T>(List<T> list, Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                    return i;
            }
            return -1;
        }

        public static void ForEach(List<T> list, Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }


        public bool TrueForAll(List<T> list, Predicate<T> match)
        {
            foreach (var item in list)
            {
                if (!match(item))
                    return false;
            }
            return true;
        }





    }
}
