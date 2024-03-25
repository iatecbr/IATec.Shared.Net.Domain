namespace IATec.Shared.Domain.Contracts.UnitOfWorks;

public interface IUnitOfWork
{
    Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
}