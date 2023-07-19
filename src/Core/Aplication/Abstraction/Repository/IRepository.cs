using Fiorella.Domain.Entites.Common;
using System.Linq.Expressions;

namespace Fiorella.Aplication.Abstraction.Repository;

public interface IRepository<T> where T :BaseEntity, new()
{
    Task AddAsync (T entity);
    void Remove(T entity);
    void Update(T entity);
    IQueryable<T> GetAll(bool isTracking=true,params string[]includes);
    IQueryable<T>GetAllFiltered(Expression<Func<T,bool>> expression);

}
