using BookStoreConsole.DataContext;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Repositories
{
    public class BookingCommandsRepository : IBookingCommandsRepository
    {
        public bool DeleteBooking(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveBooking(Booking booking)
        {
            booking.Id = new Guid();
            using (var result = new BookStoreContext())
            {
                result.bookings.Add(booking);
                result.SaveChanges();
            }
        }

        public void UpdateBooking(Booking booking)
        {
            using (var result = new BookStoreContext())
            {
                result.Entry(booking).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                result.SaveChanges();
            }
        }
    }
}
