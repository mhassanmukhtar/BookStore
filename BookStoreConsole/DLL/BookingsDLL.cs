using BookStoreConsole.DataContext;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.DLL
{
    internal class BookingsDLL
    {
        internal void addBooking(Booking newBooking)
        {
            using (var result = new BookStoreContext())
            {
                result.bookings.Add(newBooking);
                result.SaveChanges();
                Console.WriteLine("New Customer Added...");
            }
        }

        internal List<Booking> getBookings()
        {
            using (var result = new BookStoreContext())
            {
                return result.bookings.ToList();
            }
        }

        internal void getBooking(Guid id)
        {
            using (var result = new BookStoreContext())
            {
                var booking = result.bookings.FirstOrDefault(x => x.Id == id);
                Console.WriteLine("Booking Is {0}", booking.Id);
            }
        }
        internal void updateBooking()
        {
            //using (var result = new BookStoreContext())
            //{
            //    var booking = result.bookings.FirstOrDefault(x => x.Id == 1);
            //    Console.WriteLine("Booking Is {0}", booking.Id);
            //    result.bookings.Update(booking);
            //    result.SaveChanges();
            //    Console.WriteLine("Updated");
            //}
        }

    }
}
