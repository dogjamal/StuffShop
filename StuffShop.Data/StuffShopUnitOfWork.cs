using StuffShop.Data;
using StuffShop.Data.Entities;
using StuffShop.Data.Interfaces;

namespace StuffShop.Data
{
    public class StuffShopUnitOfWork : IUnitOfWork
    {
        private StuffShopDbContext _context;

        public IRepositoryBase<CategoryEntity> CategoryRepository { get; set; }
        public IRepositoryBase<SellerEntity> SellerRepository { get; set; }
        public IRepositoryBase<StuffEntity> StuffRepository { get; set; }

        public StuffShopUnitOfWork(StuffShopDbContext context,
            IRepositoryBase<CategoryEntity> categoryRepository,
            IRepositoryBase<SellerEntity> sellerRepository,
            IRepositoryBase<StuffEntity> stuffRepository)
        {
            _context = context;
            CategoryRepository = categoryRepository;
            SellerRepository = sellerRepository;
            StuffRepository = stuffRepository;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
