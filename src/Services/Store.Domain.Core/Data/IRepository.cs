using System;

namespace DomainCore.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
         IUnitOfWork UnitOfWork {get;}
    }
}