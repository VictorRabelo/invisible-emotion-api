using InvisibleEmotionDetector.Application.DTOs;

namespace InvisibleEmotionDetector.Application.Interfaces;

public interface IEmotionService
{
    Task AddEmotionInputAsync(Guid userId, EmotionInputRequest request, CancellationToken cancellationToken = default);
    Task<List<EmotionPatternDto>> GetPatternsAsync(Guid userId, CancellationToken cancellationToken = default);
    Task<List<InsightDto>> GetInsightsAsync(Guid userId, CancellationToken cancellationToken = default);
}
