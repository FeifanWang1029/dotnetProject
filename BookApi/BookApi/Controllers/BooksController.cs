using Microsoft.AspNetCore.Mvc;
using BookApi.Models;
namespace BookApi.BooksControllers
{
    // localhost:5099/api/books
    [ApiController]
    [Route("api/[Controller]")]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
            new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }

}