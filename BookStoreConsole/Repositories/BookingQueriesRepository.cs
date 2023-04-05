using BookStoreConsole.DataContext;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Repositories
{
    public class BookingQueriesRepository : IBookingQueriesRepository
    {
        public List<Booking> FindAll()
        {
            using (var result = new BookStoreContext())
            {
                return result.bookings.ToList();
            }
        }

        public Booking FindByBookID(Guid id)
        {
            using (var result = new BookStoreContext())
            {
                return result.bookings.FirstOrDefault(x => x.BookID == id);
            }
        }

        public Booking FindByID(Guid id)
        {
            using (var result = new BookStoreContext())
            {
                return result.bookings.FirstOrDefault(x => x.Id == id);
            }
        }

        public Booking FindByUserID(Guid id)
        {
            using (var result = new BookStoreContext())
            {
                return result.bookings.FirstOrDefault(x => x.CustomerID == id);
            }
        }
    }
}
