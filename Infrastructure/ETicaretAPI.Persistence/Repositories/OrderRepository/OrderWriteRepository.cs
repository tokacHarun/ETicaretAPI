using ETicaretAPI.Application.IRepositories.OrderRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Context;

namespace ETicaretAPI.Persistence.Repositories.OrderRepository
{
    public class OrderWriteRepository : WriteRepository<Order>, IWriteOrderRepository
    {
        public OrderWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
