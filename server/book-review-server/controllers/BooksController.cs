using book_review_server.models;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    readonly BookContext c;
    public BooksController(BookContext context) { c = context; }

    [HttpGet]
    public IEnumerable<Book> Get() => c.Books;
}
