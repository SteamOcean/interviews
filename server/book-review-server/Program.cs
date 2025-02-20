using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BookContext>(o => o.UseInMemoryDatabase("Books"));
builder.Services.AddControllers();
builder.Services.AddCors(o => o.AddPolicy("default", static policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().WithExposedHeaders("Etag", "Content-Disposition")));
var app = builder.Build();
app.MapControllers();
app.UseCors("default");
using (var scope = app.Services.CreateScope()) { scope.ServiceProvider.GetRequiredService<BookContext>().Database.EnsureCreated(); }
app.Run();
