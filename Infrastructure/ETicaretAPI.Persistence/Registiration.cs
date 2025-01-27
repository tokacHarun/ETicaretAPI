using ETicaretAPI.Application.IRepositories.CustomerRepository;
using ETicaretAPI.Application.IRepositories.OrderRepository;
using ETicaretAPI.Application.IRepositories.ProductRepository;
using ETicaretAPI.Persistence.Repositories.CustomerRepository;
using ETicaretAPI.Persistence.Repositories.OrderRepository;
using ETicaretAPI.Persistence.Repositories.ProductRepository;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class Registiration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddScoped<IReadCustomerRepository, CustomerReadRepository>();
            services.AddScoped<IReadOrderRepository, OrderReadRepository>();
            services.AddScoped<IReadProductRepository, ProductReadRepository>();
            services.AddScoped<IWriteProductRepository, ProductWriteRepository>();
            services.AddScoped<IWriteOrderRepository,OrderWriteRepository>();
            services.AddScoped<IWriteCustomerRepository, CustomerWriteRepository>();
        }
    }
}
