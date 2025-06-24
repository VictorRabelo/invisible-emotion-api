using InvisibleEmotionDetector.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvisibleEmotionDetector.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<EmotionInput> EmotionInputs => Set<EmotionInput>();
    public DbSet<EmotionPattern> EmotionPatterns => Set<EmotionPattern>();
    public DbSet<Insight> Insights => Set<Insight>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
