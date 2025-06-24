using InvisibleEmotionDetector.Domain.Entities;
using InvisibleEmotionDetector.Domain.Interfaces;
using InvisibleEmotionDetector.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace InvisibleEmotionDetector.Infrastructure.Repositories;

public class EmotionRepository : IEmotionRepository
{
    private readonly AppDbContext _context;

    public EmotionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddEmotionInputAsync(EmotionInput input, CancellationToken cancellationToken = default)
    {
        await _context.EmotionInputs.AddAsync(input, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<EmotionPattern>> GetPatternsAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        return await _context.EmotionPatterns.Where(p => p.UserId == userId).ToListAsync(cancellationToken);
    }

    public async Task<List<Insight>> GetInsightsAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        return await _context.Insights.Where(i => i.UserId == userId).ToListAsync(cancellationToken);
    }
}
