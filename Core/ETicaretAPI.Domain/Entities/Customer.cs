using ETicaretAPI.Domain.Comman;

namespace ETicaretAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
