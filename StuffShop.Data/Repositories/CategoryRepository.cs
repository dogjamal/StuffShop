using StuffShop.Data.Entities;

namespace StuffShop.Data.Repositories
{
    public class CategoryRepository : BaseRepository<CategoryEntity>
    {
        public CategoryRepository(StuffShopDbContext context) : base(context) { }
    }
}
