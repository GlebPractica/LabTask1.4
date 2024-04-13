using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBooksLib
{
    public class BooksList
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if (book == null)
                return;

            books.Add(book);
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.ToLower().Contains(author.ToLower())).ToList();
        }

        public List<Book> SearchByTitle(string title)
        {
            return books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
        }

        public List<Book> SearchByYear(int year)
        {
            return books.Where(b => b.Year == year).ToList();
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}
