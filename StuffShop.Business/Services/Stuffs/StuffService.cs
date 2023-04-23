using StuffShop.Business.Enum;
using StuffShop.Business.Interfaces;
using StuffShop.Business.Models;

namespace StuffShop.Business.Services.Stuffs
{
    public class StuffService : IStuffService
    {
        public StuffService() { }

        public StuffQueryServiceModel All(string brand = null, string searchTerm = null, StuffsSorting sorting = StuffsSorting.ReleaseDate, int currentPage = 1, int stuffsPerPage = int.MaxValue, bool publicOnly = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LatestStuffServiceModel> Latest()
        {
            throw new NotImplementedException();
        }
    }
}
