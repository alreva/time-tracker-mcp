var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapPost("/records", () => "Record endpoint");
app.Run();
