var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "TimeTracker.Api running");
app.Run();
