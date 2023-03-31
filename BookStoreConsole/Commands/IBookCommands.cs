using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Commands
{
    internal interface IBookCommands
    {
        void SaveBook(Book book);
        void UpdateBook(Book book,Guid id);
        void DeleteBook(Book book);
    }
}
