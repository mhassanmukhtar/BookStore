using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Models
{
    internal class Booking
    {
        public int Id { get; set; }
        public int? CustomerID { get; set; }
        public Guid? BookID { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
