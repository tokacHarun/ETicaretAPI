using ETicaretAPI.Application.IRepositories.ProductRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Context;

namespace ETicaretAPI.Persistence.Repositories.ProductRepository
{
    public class ProductReadRepository : ReadRepository<Product>, IReadProductRepository
    {
        public ProductReadRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
