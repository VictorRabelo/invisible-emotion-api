using System.Security.Claims;
using InvisibleEmotionDetector.Application.Interfaces;
using InvisibleEmotionDetector.Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvisibleEmotionDetector.Api.Controllers;

[ApiController]
[Authorize]
[Route("insights")]
public class InsightsController : ControllerBase
{
    private readonly IEmotionService _service;

    public InsightsController(IEmotionService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<InsightDto>>> Get()
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var result = await _service.GetInsightsAsync(userId);
        return Ok(result);
    }
}
