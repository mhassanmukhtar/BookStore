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
    internal class BookCommands : IBookCommands
    {
        private readonly IBookCommandsRepository _repository;
        public BookCommands(IBookCommandsRepository repository)
        {
            _repository = repository;
        }
        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void SaveBook(Book book)
        {
            _repository.SaveBook(book);
        }

        public void UpdateBook(Book book, Guid id)
        {
            _repository.UpdateBook(book, id);
        }
    }
}
