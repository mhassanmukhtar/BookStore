using BookStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BookStoreConsole.Queries;
using BookStoreConsole.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookQueries bookQueries = new BookQueries(new BookQueriesRepository());
        // GET: api/<BookController>
        [HttpGet]
        public List<Book> Get()
        {
            List<Book> books = new List<Book>();
            var booksresponse = bookQueries.FindAll();
            Book book = new Book();
            foreach (var b in booksresponse)
            {
                book.Id= b.Id;
                book.name = b.name;
                book.description = b.description;
                book.author = b.author;
                book.quantity = b.quantity;
                books.Add(book);
            }
            return books;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
