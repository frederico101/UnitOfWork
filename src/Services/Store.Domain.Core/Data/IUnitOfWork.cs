using System.Threading.Tasks;

namespace DomainCore.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}