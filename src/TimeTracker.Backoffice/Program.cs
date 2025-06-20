var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/admin", () => "Backoffice running");
app.Run();
