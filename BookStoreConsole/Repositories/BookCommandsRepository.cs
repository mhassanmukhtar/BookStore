using BookStoreConsole.DataContext;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Repositories
{
    internal class BookCommandsRepository:IBookCommandsRepository
    {
        public void SaveBook(Book book)
        {
            book.Id = new Guid();
            using (var result = new BookStoreContext())
            {
                result.books.Add(book);
                result.SaveChanges();
            }
        }

        public void UpdateBook(Book book, Guid id)
        {
            using (var result = new BookStoreContext())
            {
                var bookResponse = result.books.FirstOrDefault(x => x.Id == id);
                if (bookResponse != null) { bookResponse = book; }
                _ = result.books.Update(bookResponse);
                result.SaveChanges();
            }
        }
    }
}
