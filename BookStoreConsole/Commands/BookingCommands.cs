using BookStoreConsole.Models;
using BookStoreConsole.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Commands
{
    public class BookingCommands : IBookingCommands
    {
        private readonly IBookingCommandsRepository _repository;
        public BookingCommands(IBookingCommandsRepository repository)
        {
            _repository = repository;
        }
        public void CreateBooking(Booking booking)
        {
            _repository.SaveBooking(booking);
        }

        public bool DeleteBooking(Guid bookingId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }
    }
}
