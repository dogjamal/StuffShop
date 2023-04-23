using StuffShop.Business.Models;
using StuffShop.Business.Enum;

namespace StuffShop.Business.Interfaces
{
    public interface IStuffService
    {
        StuffQueryServiceModel All(string brand = null, string searchTerm = null, StuffsSorting sorting = StuffsSorting.ReleaseDate, int currentPage = 1, int stuffsPerPage = int.MaxValue, bool publicOnly = true);

        IEnumerable<LatestStuffServiceModel> Latest();
    }
}
