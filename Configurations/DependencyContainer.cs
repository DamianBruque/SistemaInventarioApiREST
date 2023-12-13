using Microsoft.Extensions.DependencyInjection;
using Repositories;

namespace DataAccess
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            return services;
        }

    }
}
