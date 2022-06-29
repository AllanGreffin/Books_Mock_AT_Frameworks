using Books_Mock_AT_Frameworks.Models;
using Books_Mock_AT_Frameworks.Statics;
using Microsoft.AspNetCore.Mvc;

namespace Books_Mock_AT_Frameworks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/<BookController>
        [HttpGet]
        public List<Book> GetAllBooks()
        {
            var result = BookStatic.GetAllBooks();
            return result;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book GetBookById([FromRoute]Guid id)
        {
            var result = BookStatic.GetBookById(id);
            return result;
        }

        // POST api/<BookController>
        [HttpPost]
        public void AddBook([FromBody] Book book)
        {
            BookStatic.AddBook(book);
        }

        // PUT api/<BookController>/5
        [HttpPut]
        public void UpdateBook([FromBody] Book book)
        {
            BookStatic.UpdateBook(book);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void DeleteBookById([FromRoute]Guid id)
        {
            BookStatic.RemoveBookById(id);
        }
    }
}
