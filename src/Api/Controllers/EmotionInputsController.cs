using System.Security.Claims;
using InvisibleEmotionDetector.Application.DTOs;
using InvisibleEmotionDetector.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvisibleEmotionDetector.Api.Controllers;

[ApiController]
[Authorize]
[Route("emotion-inputs")]
public class EmotionInputsController : ControllerBase
{
    private readonly IEmotionService _service;

    public EmotionInputsController(IEmotionService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Post(EmotionInputRequest request)
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        await _service.AddEmotionInputAsync(userId, request);
        return Ok();
    }
}
