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
            List<Book> books = _repository.getBooks();
            List<Book> results = new List<Book>();  
            foreach (Book item in books)
            {
                if (item.quantity != 0)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public Book FindByID(Guid id)
        {
            return _repository.getBookByID(id);
        }

    }
}
