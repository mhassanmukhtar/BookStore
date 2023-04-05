using BookStoreAPI.Models;
using BookStoreConsole.Commands;
using BookStoreConsole.Queries;
using BookStoreConsole.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingAPIController : ControllerBase
    {
        private BookingQueries _bookingQueries = new BookingQueries(new BookingQueriesRepository());
        private BookingCommands _bookingCommands = new BookingCommands(new BookingCommandsRepository());

        // GET: api/<BookingAPIController>
        [HttpGet]
        public List<Booking> Get()
        {
            List<Booking> bookings = new List<Booking>();
            var booksresponse = _bookingQueries.FindAll();
            foreach (var b in booksresponse)
            {
                Booking booking = new Booking();
                booking.Id = b.Id;
                booking.BookID = b.BookID;
                booking.CustomerName = b.CustomerName;
                booking.BookName = b.BookName;
                booking.CustomerID = b.CustomerID;
                
                bookings.Add(booking);
            }
            return bookings.ToList();
        }

        // GET api/<BookingAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookingAPIController>
        [HttpPost]
        public void Post([FromBody] Booking value)
        {
            BookStoreConsole.Models.Booking booking = new BookStoreConsole.Models.Booking();
            booking.Id = value.Id;
            booking.ReturnDate = value.ReturnDate;
            booking.BookingDate = value.BookingDate;
            booking.BookName = value.BookName;
            booking.CustomerName = value.CustomerName;
            booking.CustomerID = value.CustomerID;
            booking.BookID = value.BookID;  

            _bookingCommands.CreateBooking(booking);
        }

        // PUT api/<BookingAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookingAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
