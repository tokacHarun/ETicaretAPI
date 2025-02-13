﻿using ETicaretAPI.Application.IRepositories;
using ETicaretAPI.Domain.Comman;
using ETicaretAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIDbContext _context;

        public ReadRepository(ETicaretAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()

          => Table;

        public async Task<T> GetById(string id)

            => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));


        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)

        => await Table.FirstOrDefaultAsync(method);



        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)

            => Table.Where(method);
    }
}
