using StuffShop.Data.Entities;

namespace StuffShop.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryBase<CategoryEntity> CategoryRepository { get; set; }
        IRepositoryBase<SellerEntity> SellerRepository { get; set; }
        IRepositoryBase<StuffEntity> StuffRepository { get; set; }

        Task SaveChangesAsync();
    }
}
