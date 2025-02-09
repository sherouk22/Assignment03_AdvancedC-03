using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_AdvancedC_03
{
    public delegate string BookDelegate(Book B);
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist, BookDelegate processor)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(processor(B));
            }
        }

        public static void ProcesBooks(List<Book> blist, Func<Book, string> fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }

    }
}
