using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services;
using Services.Abstractions;
using System.Reflection;

namespace Configurations;

public static class DependencyContainer
{
    /*
    public static IServiceCollection AddProjectContextSqlServer(this IServiceCollection services)
    {
        services.AddDbContext<ProjectContext>(options => options.UseSqlServer(Environment.GetEnvironmentVariable("ConnStringWebApiUdemy")));
        return services;
    }*/
    public static IServiceCollection AddProjectContextSQLite(this IServiceCollection services)
    {
        services.AddDbContext<ProjectContext>(options => options.UseSqlite("Data Source=database.db"));
        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IUserService), typeof(UserService));
        services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));
        return services;
    }
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
        return services;
    }

}
