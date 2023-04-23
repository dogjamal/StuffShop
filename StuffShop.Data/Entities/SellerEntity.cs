using StuffShop.Data.Interfaces;

namespace StuffShop.Data.Entities
{
    public class SellerEntity : IEntityBase
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Guid UserId { get; set; }

        public IEnumerable<StuffEntity> Stuffs { get; init; } = new List<StuffEntity>();
    }
}
