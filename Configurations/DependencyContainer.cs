using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services;
using Services.Abstractions;

namespace Configurations;

public static class DependencyContainer
{
    public static IServiceCollection AddProjectContextSqlServer(this IServiceCollection services)
    {
        services.AddDbContext<ProjectContext>();
        return services;
    }
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IUserService), typeof(UserService));
        return services;
    }
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        return services;
    }

}
