using InvisibleEmotionDetector.Domain.Entities;

namespace InvisibleEmotionDetector.Domain.Interfaces;

public interface IEmotionRepository
{
    Task AddEmotionInputAsync(EmotionInput input, CancellationToken cancellationToken = default);
    Task<List<EmotionPattern>> GetPatternsAsync(Guid userId, CancellationToken cancellationToken = default);
    Task<List<Insight>> GetInsightsAsync(Guid userId, CancellationToken cancellationToken = default);
}
