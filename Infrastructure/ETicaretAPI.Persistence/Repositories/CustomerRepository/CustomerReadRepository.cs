using ETicaretAPI.Application.IRepositories.CustomerRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Context;

namespace ETicaretAPI.Persistence.Repositories.CustomerRepository
{
    public class CustomerReadRepository : ReadRepository<Customer>, IReadCustomerRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
