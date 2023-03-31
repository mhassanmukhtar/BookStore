using BookStoreConsole.DTOs;
using BookStoreConsole.Models;
using BookStoreConsole.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Queries
{
    public class BookQueries : IBookQueries
    {
        private readonly IBookQueriesRepository _repository;
        public BookQueries(IBookQueriesRepository repository)
        {
            _repository = repository;
        }

        public List<Book> FindAll()
        {
            return _repository.getBooks();
        }

        public Book FindByID(Guid id)
        {
            return _repository.getBookByID(id);
        }

    }
}
