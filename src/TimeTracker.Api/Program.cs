var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<TimeTracker.Agent.Services.IAgentService,
    TimeTracker.Agent.Services.AgentService>();
builder.Services.AddSingleton<TimeTracker.Api.Services.IChatService,
    TimeTracker.Api.Services.ChatService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/api/chat/ping", () => "pong");

app.MapGet("/api/chat/messages", (TimeTracker.Api.Services.IChatService chatService)
    => Results.Ok(chatService.GetHistory()));

app.MapPost("/api/chat/message",
    (TimeTracker.Api.Services.IChatService chatService,
        TimeTracker.Api.Models.ChatRequest request)
    => Results.Ok(new TimeTracker.Api.Models.ChatResponse(chatService.Send(request.Text).Text)));

app.Run();
