using ETicaretAPI.Domain.Comman;

namespace ETicaretAPI.Application.IRepositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(IList<T> datas);
        Task<bool> RemoveAsync(string id);
        bool RemoveRange(IList<T> datas);
        bool Remove(T model);
        bool Update(T model);
        Task<int> SaveAsync(T model);
    }
}
