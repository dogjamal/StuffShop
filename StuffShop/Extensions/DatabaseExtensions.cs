using StuffShop.Data.DatabaseSetter;

namespace StuffShop.Extensions
{
    public static class DatabaseExtensions
    {
        public static void RegisterDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDbContext(configuration);
            services.InitiallizeDb();
            services.RegisterRepositories();
        }
    }
}
