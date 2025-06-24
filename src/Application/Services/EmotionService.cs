using InvisibleEmotionDetector.Application.DTOs;
using InvisibleEmotionDetector.Application.Interfaces;
using InvisibleEmotionDetector.Domain.Entities;
using InvisibleEmotionDetector.Domain.Interfaces;

namespace InvisibleEmotionDetector.Application.Services;

public class EmotionService : IEmotionService
{
    private readonly IEmotionRepository _repository;

    public EmotionService(IEmotionRepository repository)
    {
        _repository = repository;
    }

    public async Task AddEmotionInputAsync(Guid userId, EmotionInputRequest request, CancellationToken cancellationToken = default)
    {
        var input = new EmotionInput
        {
            Id = Guid.NewGuid(),
            Emotion = request.Emotion,
            Description = request.Description,
            Timestamp = DateTime.UtcNow,
            UserId = userId
        };
        await _repository.AddEmotionInputAsync(input, cancellationToken);
    }

    public async Task<List<EmotionPatternDto>> GetPatternsAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var patterns = await _repository.GetPatternsAsync(userId, cancellationToken);
        return patterns.Select(p => new EmotionPatternDto(p.Description)).ToList();
    }

    public async Task<List<InsightDto>> GetInsightsAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var insights = await _repository.GetInsightsAsync(userId, cancellationToken);
        return insights.Select(i => new InsightDto(i.Message, i.CreatedAt)).ToList();
    }
}
