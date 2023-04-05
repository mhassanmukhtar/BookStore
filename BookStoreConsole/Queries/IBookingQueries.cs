using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Queries
{
    internal interface IBookingQueries
    {
        List<Booking> FindAll();
        Booking FindByID(Guid id);
        Booking FindByBookID(Guid id);
        Booking FindByUserID(Guid id);

    }
}
