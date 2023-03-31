using BookStoreConsole.DTOs;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Repositories
{
    public interface IBookQueriesRepository
    {
        Book getBookByID(Guid id);
        List<Book> getBooks();
    }
}
