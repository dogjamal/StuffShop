using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using StuffShop.Core.ConfigOptions;
using StuffShop.Data.Entities;
using StuffShop.Data.Interfaces;
using StuffShop.Data.Repositories;

namespace StuffShop.Data.DatabaseSetter
{
    public static class DataAccessExtensions
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryBase<CategoryEntity>, CategoryRepository>();
            services.AddScoped<IRepositoryBase<SellerEntity>, SellerRepository>();
            services.AddScoped<IRepositoryBase<StuffEntity>, StuffRepository>();
            services.AddScoped<IUnitOfWork, StuffShopUnitOfWork>();
        }

        public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.Configure<DatabaseOptions>(options => configuration.GetSection("Database").Bind(options));

            services.AddDbContext<StuffShopDbContext>(options => options.UseNpgsql(connectionString));
        }

        public static void InitiallizeDb(this IServiceCollection services)
        {
            var scopeFactory = services.BuildServiceProvider().GetRequiredService<IServiceScopeFactory>();
            var serviceProvider = scopeFactory.CreateScope().ServiceProvider;
            var dbContext = serviceProvider.GetRequiredService<StuffShopDbContext>();
            var databaseOptions = serviceProvider.GetRequiredService<IOptions<DatabaseOptions>>()?.Value;

            if (databaseOptions.NeedRecreate)
            {
                dbContext.Database.EnsureDeleted();
            }

            if (databaseOptions.UseAutoMigrations)
            {
                if (dbContext.Database.GetMigrations().Any())
                {
                    dbContext.Database.Migrate();
                }
            }
            //else
            //{
            //    dbContext.Database.EnsureCreated();
            //}
        }
    }
}
