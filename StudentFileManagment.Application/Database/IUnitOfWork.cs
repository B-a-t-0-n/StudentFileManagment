using System.Data;

namespace StudentFileManagment.Application.Database
{
    public interface IUnitOfWork
    {
        Task<IDbTransaction> BeginTransaction(CancellationToken cancellationToken = default);
        Task SaveChanges(CancellationToken cancellationToken = default);
    }
}
