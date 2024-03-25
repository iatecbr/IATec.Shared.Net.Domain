using IATec.Shared.Domain.Contracts.Entities;
using IATec.Shared.Domain.Contracts.UnitOfWorks;

namespace IATec.Shared.Domain.Contracts.Repositories.Generic;

public interface IWriteRepository<T> : IReadRepository<T>, IUnitOfWork where T : class, IEntity
{
    Task AddAsync(T entity);

    Task AddRangeAsync(IEnumerable<T> entities);

    Task RemoveAsync(T entity);

    Task RemoveRangeAsync(IEnumerable<T> entities);

    Task UpdateAsync(T entity);

    Task UpdateRangeAsync(IEnumerable<T> entities);
}