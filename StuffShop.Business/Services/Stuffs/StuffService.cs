using StuffShop.Business.Interfaces;
using StuffShop.Business.Models;

namespace StuffShop.Business.Services.Stuffs
{
    public class StuffService : IStuffService
    {
        public StuffService() { }

        public IEnumerable<LatestStuffServiceModel> Latest()
        {
            throw new NotImplementedException();
        }
    }
}
