using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Domain.Common;
using OnionArcExample.Persistence.Context;

namespace OnionArcExample.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T:BaseEntity,new()
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> Table => _context.Set<T>();

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAsync() => await Table.ToListAsync();
        public async Task<T> GetByIdAsync(Guid id) => await Table.FindAsync(id);
        public async Task<T> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
