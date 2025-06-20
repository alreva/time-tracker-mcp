namespace TimeTracker.Agent.Services;

public interface IAgentService
{
    string Process(string input);
}

public class AgentService : IAgentService
{
    public string Process(string input) => $"Processed {input}";
}
