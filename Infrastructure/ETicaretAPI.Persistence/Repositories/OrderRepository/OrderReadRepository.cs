using ETicaretAPI.Application.IRepositories.OrderRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Context;

namespace ETicaretAPI.Persistence.Repositories.OrderRepository
{
    public class OrderReadRepository : ReadRepository<Order>, IReadOrderRepository
    {
        public OrderReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
