using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmt
{

    public class Library
    {
        private List<Book> books = new List<Book>();

        // Add a book to the library
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // Remove a book by ISBN
        public void RemoveBookByISBN(string isbn)
        {
            books.RemoveAll(b => b.ISBN == isbn);
        }

        // Search for a book by title
        public Book SearchBookByTitle(string title)
        {
            return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        // List all books in the library
        public void ListBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }

}
