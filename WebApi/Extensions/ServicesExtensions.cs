using Repositories.Contracts;
using Repositories.EFCore;

namespace WebApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services) =>
            services.AddDbContext<RepositoryContext>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager,RepositoryManager>();
    }
}
