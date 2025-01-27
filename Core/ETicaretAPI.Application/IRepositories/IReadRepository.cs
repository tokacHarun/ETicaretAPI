using ETicaretAPI.Domain.Comman;
using System.Linq.Expressions;

namespace ETicaretAPI.Application.IRepositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetById(string id);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
    }
}
