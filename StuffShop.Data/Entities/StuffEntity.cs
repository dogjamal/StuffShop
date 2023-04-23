using StuffShop.Data.Interfaces;

namespace StuffShop.Data.Entities
{
    public class StuffEntity : IEntityBase
    {
        public Guid Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool isPublic { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }

        public CategoryEntity Category { get; init; }

        public Guid SellerId { get; init; }

        public SellerEntity Seller { get; init; }
    }
}
