var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Dummy endpoint
app.MapGet("/api/dummy", () =>
{
    return Results.Ok(new
    {
        status = "success",
        message = "Hello from the .NET 9 dummy endpoint!"
    });
});

app.Run();