using StuffShop.Business.Models;

namespace StuffShop.Business.Interfaces
{
    public interface IStuffService
    {
        IEnumerable<LatestStuffServiceModel> Latest();
    }
}
