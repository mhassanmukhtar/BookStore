using BookStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BookStoreConsole.Queries;
using BookStoreConsole.Commands;
using BookStoreConsole.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookQueries bookQueries = new BookQueries(new BookQueriesRepository());
        BookCommands bookCommands = new BookCommands(new BookCommandsRepository());
        // GET: api/<BookController>
        [HttpGet]
        public List<Book> Get()
        {
            List<Book> books = new List<Book>();
            var booksresponse = bookQueries.FindAll();
            foreach (var b in booksresponse)
            {
                Book book = new Book();
                book.Id= b.Id;
                book.name = b.name;
                book.description = b.description;
                book.author = b.author;
                book.quantity = b.quantity;
                books.Add(book);
            }
            return books.ToList();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Book values)
        {
            BookStoreConsole.Models.Book book = new BookStoreConsole.Models.Book();
            book.name= values.name;
            book.title = values.title;
            book.description = values.description;
            book.author = values.author;
            book.quantity = values.quantity;

            bookCommands.SaveBook(book);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            bool isDeleted = bookCommands.DeleteBook(id);
        }
    }
}
