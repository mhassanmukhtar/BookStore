using BookStoreConsole.DataContext;
using BookStoreConsole.DTOs;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Repositories
{
    public class BookQueriesRepository : IBookQueriesRepository
    {
        public Book getBookByID(Guid id)
        {
            using (var result = new BookStoreContext())
            {
                return result.books.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Book> getBooks()
        {
            using (var result = new BookStoreContext())
            {
                return result.books.ToList();
            }
        }
    }
    }
