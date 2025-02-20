using book_review_server.models;
using Microsoft.EntityFrameworkCore;

namespace book_review_server.models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
    }
}

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options) { }
    public DbSet<Book> Books { get; set; }
    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<Book>().HasData(
            MockUtil.GenerateBooks(1000)
        );
    }
}

public static class MockUtil
{
    public static IEnumerable<Book> GenerateBooks(int n)
    {
        var list = new List<Book>();
        for (var i = 1; i <= n; i++)
            list.Add(new Book { Id = i, Title = "Title" + i, Author = "Author" + i });
        return list;
    }
}
