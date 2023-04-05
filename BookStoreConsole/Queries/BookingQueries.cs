using BookStoreConsole.Models;
using BookStoreConsole.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Queries
{
    public class BookingQueries : IBookingQueries
    {
        private readonly IBookingQueriesRepository _repository;
        public BookingQueries(IBookingQueriesRepository repository)
        {
            _repository = repository;
        }
        public List<Booking> FindAll()
        {
            return _repository.FindAll();
        }

        public Booking FindByBookID(Guid id)
        {
            throw new NotImplementedException();
        }

        public Booking FindByID(Guid id)
        {
            return _repository.FindByID(id);
        }

        public Booking FindByUserID(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
