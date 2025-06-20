using TimeTracker.Api.Models;
using TimeTracker.Agent.Services;

namespace TimeTracker.Api.Services;

public interface IChatService
{
    ChatMessage Send(string userText);
    IReadOnlyList<ChatMessage> GetHistory();
}

public class ChatService : IChatService
{
    private readonly IAgentService _agent;
    private readonly List<ChatMessage> _messages = new();

    public ChatService(IAgentService agent)
    {
        _agent = agent;
    }

    public IReadOnlyList<ChatMessage> GetHistory() => _messages.AsReadOnly();

    public ChatMessage Send(string userText)
    {
        var userMessage = new ChatMessage("user", userText, DateTime.UtcNow);
        _messages.Add(userMessage);
        var responseText = _agent.Process(userText);
        var agentMessage = new ChatMessage("agent", responseText, DateTime.UtcNow);
        _messages.Add(agentMessage);
        return agentMessage;
    }
}
