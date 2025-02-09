using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_AdvancedC_03
{
    public class Book
    {

        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }


        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            string authors = string.Join(", ", Authors);
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {authors}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
        }


    }
}