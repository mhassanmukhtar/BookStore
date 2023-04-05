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
       private BookQueries _bookQueries = new BookQueries(new BookQueriesRepository());
       private BookCommands _bookCommands = new BookCommands(new BookCommandsRepository());
        // GET: api/<BookController>
        [HttpGet]
        public List<Book> Get()
        {
            List<Book> books = new List<Book>();
            var booksresponse = _bookQueries.FindAll();
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
        public Book Get(Guid id)
        {
            var booksresponse = _bookQueries.FindByID(id);
            Book book = new Book
            {
                Id = booksresponse.Id,
                name = booksresponse.name,
                description = booksresponse.description,
                author = booksresponse.author,
                quantity = booksresponse.quantity,
                IsBooked = booksresponse.IsBooked
            };

            return book;
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

            _bookCommands.SaveBook(book);
        }

        // PUT api/<BookController>/5
        [HttpPut]
        public void Put([FromBody] Book values)
        {
            BookStoreConsole.Models.Book bookObj = new BookStoreConsole.Models.Book();
            bookObj.Id = values.Id;
            bookObj.name = values.name;
            bookObj.title = values.title;
            bookObj.description = values.description;
            bookObj.author = values.author;
            bookObj.quantity = values.quantity;

            _bookCommands.UpdateBook(bookObj);
        }

        [HttpPut("{id}")]
        public void Put(Guid id)
        {
            //bookCommands.UpdateBook(id);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            bool isDeleted = _bookCommands.DeleteBook(id);
        }
    }
}
