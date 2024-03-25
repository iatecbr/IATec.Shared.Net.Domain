namespace IATec.Shared.Domain.Contracts.Transactions;

public interface ITransaction
{
    void BeginTransaction();
    void CommitTransaction();
    void RollbackTransaction();
}