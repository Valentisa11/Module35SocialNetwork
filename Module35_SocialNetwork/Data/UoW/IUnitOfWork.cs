using Module35SocialNetwork.Data.Repository;
using System;
using Module35SocialNetwork.Models;

namespace Module35SocialNetwork.Data.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges(bool ensureAutoHistory = false);

        IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = true) where TEntity : class;
    }
}