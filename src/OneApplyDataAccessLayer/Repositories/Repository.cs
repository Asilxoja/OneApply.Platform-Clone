using Microsoft.EntityFrameworkCore;
using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities;
using OneApplyDataAccessLayer.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OneApplyDataAccessLayer.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));
        

        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
        }

        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public Task<IQueryable<TEntity>> GetAllAsync()
    {
        var list = _dbSet.AsNoTracking()
                         .AsQueryable();

        return Task.FromResult(list);
    }
    public async Task<TEntity> GetByIdAsync(int id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(c => c.Id == id);

        return entity ?? throw new Exception($"GetByIdAsync entity not found for ID: {id}");
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}
