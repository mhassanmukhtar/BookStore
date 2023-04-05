using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Commands
{
    public interface IBookingCommands
    {
        void CreateBooking(Booking booking);
        void UpdateBooking(Booking booking);
        bool DeleteBooking(Guid bookingId);
    }
}
