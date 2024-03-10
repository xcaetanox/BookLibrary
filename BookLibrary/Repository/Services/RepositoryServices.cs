using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository.Services
{
    public class RepositoryServices<T> : IRepositoryServices<T> where T : class
    {


        public readonly SqlServerContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryServices(SqlServerContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }


}
