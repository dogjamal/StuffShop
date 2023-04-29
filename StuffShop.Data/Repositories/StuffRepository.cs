using StuffShop.Data.Entities;

namespace StuffShop.Data.Repositories
{
    public class StuffRepository : BaseRepository<StuffEntity>
    {
        public StuffRepository(StuffShopDbContext context) : base(context) { }
    }
}
