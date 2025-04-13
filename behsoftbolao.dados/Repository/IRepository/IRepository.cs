using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BehSoft.DataAccess.Repository.IRepository;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000, string? includeProperties = null);
    Task<T> Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
    Task Add(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
}
