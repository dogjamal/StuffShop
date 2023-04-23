using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StuffShop.Data.Entities;
using static StuffShop.Data.Constants.DataConstants.Seller;

namespace StuffShop.Data.EntitiesConfigurations
{
    public class SellerConfiguration : IEntityTypeConfiguration<SellerEntity>
    {
        public void Configure(EntityTypeBuilder<SellerEntity> builder)
        {
            builder
                .HasKey(sl => sl.Id);

            builder
                .Property(sl => sl.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            builder
                .Property(sl => sl.PhoneNumber)
                .IsRequired()
                .HasMaxLength(PhoneNumberMaxLength);

            builder
                .Property(sl => sl.UserId)
                .IsRequired();

            builder
                .HasOne<IdentityUser>()
                .WithOne()
                .HasForeignKey<SellerEntity>(sl => sl.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
