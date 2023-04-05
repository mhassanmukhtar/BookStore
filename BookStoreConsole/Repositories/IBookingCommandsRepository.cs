using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Repositories
{
    public interface IBookingCommandsRepository
    {
        void SaveBooking(Booking book);
        void UpdateBooking(Booking book);
        bool DeleteBooking(Guid id);
    }
}
