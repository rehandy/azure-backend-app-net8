var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/api/data", () => Results.Ok(new { Message = "Hello from Backend (.NET 8)!", Timestamp = DateTime.UtcNow }));
app.Run();
