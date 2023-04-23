using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StuffShop.Data.Entities;
using static StuffShop.Data.Constants.DataConstants.Stuffs;

namespace StuffShop.Data.EntitiesConfigurations
{
    public class StuffConfiguration : IEntityTypeConfiguration<StuffEntity>
    {
        public void Configure(EntityTypeBuilder<StuffEntity> builder)
        {
            builder
                .HasKey(sf => sf.Id);

            builder
                .Property(sf => sf.Brand)
                .IsRequired()
                .HasMaxLength(BrandMaxLength);

            builder
                .Property(sf => sf.Model)
                .IsRequired()
                .HasMaxLength(ModelMaxLength);

            builder
                .Property(sf => sf.Description)
                .IsRequired();

            builder
                .Property(sf => sf.ImageUrl)
                .IsRequired();

            builder
                .Property(sf => sf.Color)
                .IsRequired()
                .HasMaxLength(ColorMaxLength);

            builder
                .HasOne(sf => sf.Category)
                .WithMany(c => c.Stuffs)
                .HasForeignKey(sf => sf.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(sf => sf.Seller)
                .WithMany(sl => sl.Stuffs)
                .HasForeignKey(sf => sf.SellerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
