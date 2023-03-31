using BookStoreConsole.DataContext;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.DLL
{
    internal class BookDLL
    {
        internal void addBook(Book newBook)
        {
            newBook.Id = new Guid();
            using (var result = new BookStoreContext())
            {
                result.books.Add(newBook);
                result.SaveChanges();
                Console.WriteLine("New Book Added...");
            }
        }

        internal List<Book> getBooks()
        {
            using (var result = new BookStoreContext())
            {
                 return result.books.ToList();
            }  
        }

        internal void getBook()
        {
            using (var result = new BookStoreContext())
            {
                var book = result.books.FirstOrDefault(x => x.Id == new Guid("e36e0b66-7ceb-4e8a-e49e-08db30cd8476"));
                Console.WriteLine("Book Is {0}", book.title);
            }
        }
        internal void updateBook()
        {
            using (var result = new BookStoreContext())
            {
                var book = result.books.FirstOrDefault(x => x.Id == new Guid("e36e0b66-7ceb-4e8a-e49e-08db30cd8476"));
                Console.WriteLine("Book Is {0}", book.title);

                book.quantity = 0;

                result.books.Update(book);
                result.SaveChanges();

                Console.WriteLine("Updated");
            }
        }
    }
}
