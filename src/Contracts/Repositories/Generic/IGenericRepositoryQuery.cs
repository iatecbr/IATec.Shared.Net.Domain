using System.Linq.Expressions;
using IATec.Shared.Domain.Contracts.Entities;

namespace IATec.Shared.Domain.Contracts.Repositories.Generic;

public interface IGenericRepositoryQuery
{
    IQueryable<T> Query<T>(params Expression<Func<T, object>>[] includeProperties) where T : class, IEntity;
}