using System.Threading;
using System.Threading.Tasks;
using QT.Repository.Pattern.Infrastructure;
using QT.Repository.Pattern.Repositories;

namespace QT.Repository.Pattern.UnitOfWork
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class, IObjectState;
    }
}
