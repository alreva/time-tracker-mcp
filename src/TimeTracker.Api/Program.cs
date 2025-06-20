var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<TimeTracker.Agent.Services.IAgentService,
    TimeTracker.Agent.Services.AgentService>();
builder.Services.AddSingleton<TimeTracker.Api.Services.IChatService,
    TimeTracker.Api.Services.ChatService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
