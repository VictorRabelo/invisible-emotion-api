using System.Security.Claims;
using InvisibleEmotionDetector.Application.Interfaces;
using InvisibleEmotionDetector.Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvisibleEmotionDetector.Api.Controllers;

[ApiController]
[Authorize]
[Route("emotion-patterns")]
public class EmotionPatternsController : ControllerBase
{
    private readonly IEmotionService _service;

    public EmotionPatternsController(IEmotionService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<EmotionPatternDto>>> Get()
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var result = await _service.GetPatternsAsync(userId);
        return Ok(result);
    }
}
