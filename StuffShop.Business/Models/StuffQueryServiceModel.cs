namespace StuffShop.Business.Models
{
    public class StuffQueryServiceModel
    {
        public int CurrentPage { get; init; }

        public int StuffsPerPage { get; init; }

        public int TotalStuffs { get; set; }

        public IEnumerable<StuffServiceModel> Stuffs { get; init; }
    }
}
