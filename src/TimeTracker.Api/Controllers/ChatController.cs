using Microsoft.AspNetCore.Mvc;
using TimeTracker.Api.Models;
using TimeTracker.Api.Services;

namespace TimeTracker.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ChatController : ControllerBase
{
    private readonly IChatService _chatService;

    public ChatController(IChatService chatService)
    {
        _chatService = chatService;
    }

    [HttpGet("ping")]
    public IActionResult Ping() => Ok("pong");

    [HttpGet("messages")]
    public ActionResult<IEnumerable<ChatMessage>> GetMessages()
        => Ok(_chatService.GetHistory());

    [HttpPost("message")]
    public ActionResult<ChatResponse> PostMessage(ChatRequest request)
    {
        var response = _chatService.Send(request.Text);
        return Ok(new ChatResponse(response.Text));
    }
}
