using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BehSoft.DataAccess.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly BolaoDbContext _dbContext;
    internal DbSet<T> dbSet;

    public Repository(BolaoDbContext dBContext)
    {
        _dbContext = dBContext;
        this.dbSet = _dbContext.Set<T>();
        //_dbContext.Categories == dbSet;
    }
    public async Task Add(T entity)
    {
        await this.dbSet.AddAsync(entity);
    }

    public async Task<T?> Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
    {
        IQueryable<T> query = this.dbSet.AsQueryable();
        query = query.Where(filter);
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProp in includeProperties
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }
        return await query.FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<T>> GetAll(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000, string? includeProperties = null)
    {
        IQueryable<T> query = this.dbSet;
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProp in includeProperties
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp);
            }
        }

        // Filtering
        if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
        {
            // TODO pensar em uma forma generica de conseguir testar se o filterOn eh uma propriedade de T
            // query = query.Where(x => x.filterOn == filterQuery);
        }

        // Sorting
        if (!string.IsNullOrWhiteSpace(sortBy))
        {
            // TODO pensar em uma forma generica de conseguir testar se o filterOn eh uma propriedade de T
            // query = isAscending ? query.OrderBy(x => x.Nome) : query.OrderByDescending(x => x.Nome);
        }

        // Pagination
        var skipResults = (pageNumber - 1) * pageSize;

        return await query.Skip(skipResults).Take(pageSize).ToListAsync();
    }

    public void Remove(T entity)
    {
        this.dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        this.dbSet.RemoveRange(entities);
    }
}
