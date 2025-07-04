var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Dummy endpoint
app.MapGet("/api/dummy", () =>
{
    return Results.Ok(new
    {
        status = "success",
        message = "Hello Agatha/vesion 2"
    });
});

app.Run();