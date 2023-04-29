using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StuffShop.Data.Entities;
using System.Reflection;

namespace StuffShop.Data
{
    public class StuffShopDbContext : IdentityDbContext
    {
        public StuffShopDbContext(DbContextOptions<StuffShopDbContext> options) : base(options) {}

        public DbSet<StuffEntity> Stuffs { get; init; }

        public DbSet<CategoryEntity> Categories { get; init; }

        public DbSet<SellerEntity> Sellers { get; init; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}