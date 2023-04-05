using BookStoreConsole.DataContext;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Repositories
{
    public class BookCommandsRepository:IBookCommandsRepository
    {
        public bool BookIt(Guid id)
        {
            using (var result = new BookStoreContext())
            {
                return true;
            }
        }

        public bool DeleteBook(Guid id)
        {
            using (var result = new BookStoreContext())
            {
                var bookResponse = result.books.FirstOrDefault(x => x.Id == id);
                if (bookResponse != null)
                {
                    var isDeleted = result.books.Remove(bookResponse);
                    result.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
              
            }
        }

        public void SaveBook(Book book)
        {
            book.Id = new Guid();
            using (var result = new BookStoreContext())
            {
                result.books.Add(book);
                result.SaveChanges();
            }
        }

        public void UpdateBook(Book book)
        {
            using (var result = new BookStoreContext())
            {
                result.Entry(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;           
                result.SaveChanges();
            }
        }
    }
}
