namespace StuffShop.Business.Models
{
    public class IndexViewModel
    {
        public int TotalStuffs { get; init; }

        public int TotalUsers { get; init; }

        public int TotalPurchases { get; init; }

        public List<LatestStuffServiceModel> Stuffs { get; init; }
    }
}
