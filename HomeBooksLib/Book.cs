using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBooksLib
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"\"{Title}\" by {Author}, {Year}";
        }
    }
}
