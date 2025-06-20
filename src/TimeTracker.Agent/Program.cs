var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TimeTracker.Agent.Services.IAgentService,
    TimeTracker.Agent.Services.AgentService>();

var app = builder.Build();

app.MapPost("/records", (string input, TimeTracker.Agent.Services.IAgentService service) =>
{
    return service.Process(input);
});

app.Run();
