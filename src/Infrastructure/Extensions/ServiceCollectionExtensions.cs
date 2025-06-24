using InvisibleEmotionDetector.Application.Interfaces;
using InvisibleEmotionDetector.Application.Services;
using InvisibleEmotionDetector.Domain.Entities;
using InvisibleEmotionDetector.Domain.Interfaces;
using InvisibleEmotionDetector.Infrastructure.Persistence;
using InvisibleEmotionDetector.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InvisibleEmotionDetector.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped<IGenericRepository<User>, GenericRepository<User>>();
        services.AddScoped<IEmotionRepository, EmotionRepository>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IEmotionService, EmotionService>();
        return services;
    }
}
