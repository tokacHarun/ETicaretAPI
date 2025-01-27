using ETicaretAPI.Domain.Comman;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public IList<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}
