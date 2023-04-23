using StuffShop.Data.Interfaces;

namespace StuffShop.Data.Entities
{
    public class CategoryEntity : IEntityBase
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<StuffEntity> Stuffs { get; init; } = new List<StuffEntity>();
    }
}
