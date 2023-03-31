using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Repositories
{
    internal interface IBookCommandsRepository
    {
        void SaveBook(Book book);
        void UpdateBook(Book book, Guid id);
    }
}
