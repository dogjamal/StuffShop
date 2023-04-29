using StuffShop.Data.Entities;

namespace StuffShop.Data.Repositories
{
    public class SellerRepository : BaseRepository<SellerEntity>
    {
        public SellerRepository(StuffShopDbContext context) : base(context) { }
    }
}
