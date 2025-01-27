using ETicaretAPI.Domain.Comman;

namespace ETicaretAPI.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
