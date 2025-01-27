using ETicaretAPI.Domain.Comman;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Application.IRepositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table {  get;  }
    }
}
