using BookStoreConsole.DataContext;
using BookStoreConsole.Models;
using BookStoreConsole.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Commands
{
    public class BookCommands : IBookCommands
    {
        private readonly IBookCommandsRepository _repository;
        public BookCommands(IBookCommandsRepository repository)
        {
            _repository = repository;
        }

        public bool BookIt(Guid Id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBook(Guid bookId)
        {
           return _repository.DeleteBook(bookId);
        }

        public void SaveBook(Book book)
        {
            _repository.SaveBook(book);
        }

        public void UpdateBook(Book book)
        {
            _repository.UpdateBook(book);
        }
    }
}
